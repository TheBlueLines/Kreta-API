using System.Text;
using System.Text.Json;

namespace TTMC.Kréta
{
	public class Engine
	{
		HttpClient httpClient = new();
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
		public LoginDetails? loginDetails = null;
		public HttpClient client = new();
		private string institute = string.Empty;
		private Task? autoRefresh = null;
		public Account(string instituteCode, string username, string password, string userAgent = "KretaAPI")
		{
			HttpClient httpClient = new();
			AuthorizationPolicy ap = new(instituteCode, username);
			httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(userAgent);
			httpClient.DefaultRequestHeaders.Add("X-Authorizationpolicy-Key", ap.key);
			httpClient.DefaultRequestHeaders.Add("X-Authorizationpolicy-Version", ap.version);
			httpClient.DefaultRequestHeaders.Add("X-Authorizationpolicy-Nonce", ap.nonce);
			StringContent req = new StringContent("userName=" + username + "&password=" + password + "&institute_code=" + instituteCode + "&grant_type=password&client_id=" + KretaAPI.clientId, Encoding.UTF8, "application/x-www-form-urlencoded");
			HttpResponseMessage resp = httpClient.PostAsync(KretaAPI.login, req).Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			loginDetails = JsonSerializer.Deserialize<LoginDetails>(json);
			if (loginDetails != null)
			{
				institute = instituteCode;
				client.DefaultRequestHeaders.UserAgent.ParseAdd(userAgent);
				client.DefaultRequestHeaders.Add("Authorization", loginDetails.token_type + " " + loginDetails.access_token);
				autoRefresh = new Task(() => AutoRefresh(loginDetails.expires_in));
				autoRefresh.Start();
			}
		}
		private void AutoRefresh(int num)
		{
			Thread.Sleep(num);
			RefreshToken();
		}
		public List<Timetable> OrarendElemek(DateTime datumTol, DateTime datumIg)
		{
			if (client.DefaultRequestHeaders.Contains("Authorization"))
			{
				string one = datumTol.ToString("u").Split(' ')[0];
				string two = datumIg.ToString("u").Split(' ')[0];
				string json = client.GetStringAsync("https://" + institute + ".e-kreta.hu/ellenorzo/V3/Sajat/OrarendElemek?datumTol=" + one + "&datumIg=" + two).Result;
				List<Timetable>? tt = JsonSerializer.Deserialize<List<Timetable>>(json);
				if (tt != null)
				{
					return tt;
				}
			}
			return new();
		}
		public List<Absences> Mulasztasok(DateTime? datumTol = null, DateTime? datumIg = null)
		{
			if (client.DefaultRequestHeaders.Contains("Authorization"))
			{
				string url = "https://" + institute + ".e-kreta.hu/ellenorzo/V3/Sajat/Mulasztasok";
				if (datumTol != null)
				{
					url += "?datumTol=" + datumTol.Value.ToString("u").Split(' ')[0];
				}
				if (datumIg != null)
				{
					url += "?datumTol=" + datumIg.Value.ToString("u").Split(' ')[0];
				}
				string json = client.GetStringAsync(url).Result;
				List<Absences>? absences = JsonSerializer.Deserialize<List<Absences>>(json);
				if (absences != null)
				{
					return absences;
				}
			}
			return new();
		}
		public List<Evaluations> Ertekelesek(DateTime? datumTol = null, DateTime? datumIg = null)
		{
			if (client.DefaultRequestHeaders.Contains("Authorization"))
			{
				string url = "https://" + institute + ".e-kreta.hu/ellenorzo/V3/Sajat/Ertekelesek";
				if (datumTol != null)
				{
					url += "?datumTol=" + datumTol.Value.ToString("u").Split(' ')[0];
				}
				if (datumIg != null)
				{
					url += "?datumTol=" + datumIg.Value.ToString("u").Split(' ')[0];
				}
				string json = client.GetStringAsync(url).Result;
				List<Evaluations>? evaluations = JsonSerializer.Deserialize<List<Evaluations>>(json);
				if (evaluations != null)
				{
					return evaluations;
				}
			}
			return new();
		}
		public void RefreshToken()
		{
			if (client.DefaultRequestHeaders.Contains("Authorization") && loginDetails != null)
			{
				StringContent content = new("institute_code=" + institute + "&refresh_token=" + loginDetails.refresh_token + "&grant_type=refresh_token&client_id=kreta-ellenorzo-mobile-android", Encoding.UTF8, "application/x-www-form-urlencoded");
				HttpResponseMessage resp = client.PostAsync("https://idp.e-kreta.hu/connect/token", content).Result;
				loginDetails = JsonSerializer.Deserialize<LoginDetails>(resp.Content.ReadAsStringAsync().Result);
				if (loginDetails != null)
				{
					client.DefaultRequestHeaders.Remove("Authorization");
					client.DefaultRequestHeaders.Add("Authorization", loginDetails.token_type + " " + loginDetails.access_token);
					autoRefresh = new Task(() => AutoRefresh(loginDetails.expires_in));
					autoRefresh.Start();
				}
			}
		}
		public List<Note> Feljegyzesek()
		{
			if (client.DefaultRequestHeaders.Contains("Authorization"))
			{
				string json = client.GetStringAsync(KretaAPI.notes(institute)).Result;
				List<Note>? notes = JsonSerializer.Deserialize<List<Note>>(json);
				if (notes != null)
				{
					return notes;
				}
			}
			return new();
		}
		public List<Message> Postaladaelemek(MessageType select)
		{
			if (client.DefaultRequestHeaders.Contains("Authorization"))
			{
				string json = client.GetStringAsync("https://eugyintezes.e-kreta.hu/api/v1/kommunikacio/postaladaelemek/" + select.type).Result;
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
		public List<Message> Postaladaelemek(byte select)
		{
			if (client.DefaultRequestHeaders.Contains("Authorization") & select >= 0 & select <= 2)
			{
				string[] list = { "beerkezett", "elkuldott", "torolt" };
				string json = client.GetStringAsync("https://eugyintezes.e-kreta.hu/api/v1/kommunikacio/postaladaelemek/" + list[select]).Result;
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
		public List<Exam> BejelentettSzamonkeresek(DateTime? datumTol = null)
		{
			if (client.DefaultRequestHeaders.Contains("Authorization"))
			{
				string url = "https://" + institute + ".e-kreta.hu/ellenorzo/V3/Sajat/BejelentettSzamonkeresek";
				if (datumTol != null)
				{
					url += "?datumTol=" + datumTol.Value.ToString("u").Split(' ')[0];
				}
				string json = client.GetStringAsync(url).Result;
				List<Exam>? exams = JsonSerializer.Deserialize<List<Exam>>(json);
				if (exams != null)
				{
					return exams;
				}
			}
			return new();
		}
		public StudentInfo TanuloAdatlap()
		{
			if (client.DefaultRequestHeaders.Contains("Authorization"))
			{
				string json = client.GetStringAsync("https://" + institute + ".e-kreta.hu/ellenorzo/V3/Sajat/TanuloAdatlap").Result;
				StudentInfo? si = JsonSerializer.Deserialize<StudentInfo>(json);
				if (si != null)
				{
					return si;
				}
			}
			return new();
		}
		public List<Homework> HaziFeladatok(DateTime datumTol)
		{
			if (client.DefaultRequestHeaders.Contains("Authorization"))
			{
				string json = client.GetStringAsync(KretaAPI.homework(institute, datumTol)).Result;
				List<Homework>? homework = JsonSerializer.Deserialize<List<Homework>>(json);
				if (homework != null)
				{
					return homework;
				}
			}
			return new();
		}
		public School Intezmenyek()
		{
			if (client.DefaultRequestHeaders.Contains("Authorization"))
			{
				string json = client.GetStringAsync(KretaAPI.capabilities(institute)).Result;
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