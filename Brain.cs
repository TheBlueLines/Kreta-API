using System.Text.Json;

namespace TTMC.Kréta
{
	public class Engine
	{
		private HttpClient httpClient = new();
		public Engine(string userAgent = "KretaAPI", string apiKey = "7856d350-1fda-45f5-822d-e1a2f3f1acf0")
		{
			httpClient.DefaultRequestHeaders.Add("apiKey", apiKey);
			httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(userAgent);
		}
		public List<Institute> Institutes(params ushort[] ids)
		{
			if (ids.Length == 0)
			{
				string resp = httpClient.GetStringAsync("https://kretaglobalmobileapi2.ekreta.hu/api/v3/Institute").Result;
				List<Institute>? back = JsonSerializer.Deserialize<List<Institute>>(resp);
				return back == null ? new() : back;
			}
			else
			{
				List<Institute> back = new();
				foreach (ushort value in ids)
				{
					Institute? tmp = Institute(value);
					if (tmp != null)
					{
						back.Add(tmp);
					}
				}
				return back;
			}
		}
		public Institute? Institute(ushort id)
		{
			string resp = httpClient.GetStringAsync("https://kretaglobalmobileapi2.ekreta.hu/api/v3/Institute/" + id).Result;
			return JsonSerializer.Deserialize<Institute>(resp);
		}
	}
	public class Account
	{
		public LoginDetails loginDetails;
		public HttpClient client = new();
		private string institute = string.Empty;
		private Task? autoRefresh = null;
		private KretaAPI kretaAPI;
		public Account(string instituteCode, string username, string password, string userAgent = "KretaAPI")
		{
			kretaAPI = new(instituteCode);
			HttpClient httpClient = new();
			AuthorizationPolicy ap = new(instituteCode, username);
			httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(userAgent);
			httpClient.DefaultRequestHeaders.Add("X-Authorizationpolicy-Key", ap.key);
			httpClient.DefaultRequestHeaders.Add("X-Authorizationpolicy-Version", ap.version);
			httpClient.DefaultRequestHeaders.Add("X-Authorizationpolicy-Nonce", ap.nonce);
			Dictionary<string, string> tmp = new() { { "userName", username }, { "password", password }, { "institute_code", instituteCode }, { "grant_type", "password" }, { "client_id", KretaAPI.clientId } };
			FormUrlEncodedContent content = new(tmp);
			HttpResponseMessage resp = httpClient.PostAsync(KretaAPI.login, content).Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			loginDetails = Enhance<LoginDetails>(json);
			institute = instituteCode;
			client.DefaultRequestHeaders.UserAgent.ParseAdd(userAgent);
			client.DefaultRequestHeaders.Add("Authorization", loginDetails.token_type + " " + loginDetails.access_token);
			autoRefresh = new Task(() => AutoRefresh(loginDetails.expires_in));
			autoRefresh.Start();
		}
		internal static T Enhance<T>(string text)
		{
			if (text.StartsWith('{') && text.EndsWith('}'))
			{
				Error? error = JsonSerializer.Deserialize<Error>(text);
				if (error != null && !string.IsNullOrEmpty(error.error_description))
				{
					throw new Exception(error.error_description);
				}
			}
			T? nzx = JsonSerializer.Deserialize<T>(text);
			if (nzx != null)
			{
				return nzx;
			}
			throw new Exception(text);
		}
		private void AutoRefresh(int num)
		{
			Thread.Sleep(num * 1000);
			RefreshToken();
		}
		public List<Lesson> Lessons(DateTime? fromDate, DateTime? toDate)
		{
			if (client.DefaultRequestHeaders.Contains("Authorization"))
			{
				string json = client.GetStringAsync(kretaAPI.Lessons(fromDate, toDate)).Result;
				List<Lesson>? lessons = JsonSerializer.Deserialize<List<Lesson>>(json);
				if (lessons != null)
				{
					return lessons;
				}
			}
			return new();
		}
		public List<Omission> Omissions(DateTime? fromDate = null, DateTime? toDate = null)
		{
			if (client.DefaultRequestHeaders.Contains("Authorization"))
			{
				string json = client.GetStringAsync(kretaAPI.Omissions(fromDate, toDate)).Result;
				List<Omission>? omissions = JsonSerializer.Deserialize<List<Omission>>(json);
				if (omissions != null)
				{
					return omissions;
				}
			}
			return new();
		}
		public List<Evaluation> Evaluations(DateTime? fromDate = null, DateTime? toDate = null)
		{
			if (client.DefaultRequestHeaders.Contains("Authorization"))
			{
				string json = client.GetStringAsync(kretaAPI.Evaluations(fromDate, toDate)).Result;
				List<Evaluation>? evaluations = JsonSerializer.Deserialize<List<Evaluation>>(json);
				if (evaluations != null)
				{
					return evaluations;
				}
			}
			return new();
		}
		public void RefreshToken()
		{
			if (client.DefaultRequestHeaders.Contains("Authorization") && !string.IsNullOrEmpty(loginDetails.refresh_token))
			{
				Dictionary<string, string> tmp = new() { { "institute_code", institute }, { "refresh_token", loginDetails.refresh_token }, { "grant_type", "refresh_token" }, { "client_id", KretaAPI.clientId } };
				FormUrlEncodedContent content = new(tmp);
				HttpResponseMessage resp = client.PostAsync(KretaAPI.login, content).Result;
				loginDetails = Enhance<LoginDetails>(resp.Content.ReadAsStringAsync().Result);
				if (loginDetails != null)
				{
					client.DefaultRequestHeaders.Remove("Authorization");
					client.DefaultRequestHeaders.Add("Authorization", loginDetails.token_type + " " + loginDetails.access_token);
					autoRefresh = new Task(() => AutoRefresh(loginDetails.expires_in));
					autoRefresh.Start();
				}
			}
		}
		public List<Note> Notes(DateTime? fromDate = null, DateTime? toDate = null)
		{
			if (client.DefaultRequestHeaders.Contains("Authorization"))
			{
				string json = client.GetStringAsync(kretaAPI.Notes(fromDate, toDate)).Result;
				List<Note>? notes = JsonSerializer.Deserialize<List<Note>>(json);
				if (notes != null)
				{
					return notes;
				}
			}
			return new();
		}
		public List<Message> Messages(MessageType select)
		{
			if (client.DefaultRequestHeaders.Contains("Authorization"))
			{
				string json = client.GetStringAsync(Kreta.Admin + AdminEndpoints.getAllMessages(select.type)).Result;
				List<Message>? result = JsonSerializer.Deserialize<List<Message>>(json);
				if (result != null)
				{
					foreach (Message message in result)
					{
						message.account = this;
					}
					return result;
				}
				return new();
			}
			return new();
		}
		public List<Message> Messages(ulong select)
		{
			if (client.DefaultRequestHeaders.Contains("Authorization") & select >= 0 & select <= 2)
			{
				string json = client.GetStringAsync(Kreta.Admin + AdminEndpoints.getMessage(select)).Result;
				List<Message>? result = JsonSerializer.Deserialize<List<Message>>(json);
				if (result != null)
				{
					foreach (Message message in result)
					{
						message.account = this;
					}
					return result;
				}
				return new();
			}
			return new();
		}
		public List<AnnouncedTest> AnnouncedTests(DateTime? fromDate = null, DateTime? toDate = null)
		{
			if (client.DefaultRequestHeaders.Contains("Authorization"))
			{
				string json = client.GetStringAsync(kretaAPI.AnnouncedTests(fromDate, toDate)).Result;
				List<AnnouncedTest>? announcedTests = JsonSerializer.Deserialize<List<AnnouncedTest>>(json);
				if (announcedTests != null)
				{
					return announcedTests;
				}
			}
			return new();
		}
		public List<Homework> Homeworks(DateTime? fromDate = null, DateTime? toDate = null)
		{
			if (client.DefaultRequestHeaders.Contains("Authorization"))
			{
				string json = client.GetStringAsync(kretaAPI.Homeworks(fromDate, toDate)).Result;
				List<Homework>? homework = JsonSerializer.Deserialize<List<Homework>>(json);
				if (homework != null)
				{
					return homework;
				}
			}
			return new();
		}
		public StudentInfo student
		{
			get
			{
				if (client.DefaultRequestHeaders.Contains("Authorization"))
				{
					string json = client.GetStringAsync(kretaAPI.student).Result;
					StudentInfo? si = JsonSerializer.Deserialize<StudentInfo>(json);
					if (si != null)
					{
						return si;
					}
				}
				return new();
			}
		}
		public School capabilities
		{
			get
			{
				if (client.DefaultRequestHeaders.Contains("Authorization"))
				{
					string json = client.GetStringAsync(kretaAPI.capabilities).Result;
					School? school = JsonSerializer.Deserialize<School>(json);
					if (school != null)
					{
						return school;
					}
				}
				return new();
			}
		}
	}
}