using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace TTMC.Kréta
{
	public class Engine
	{
		HMACSHA512 hmac = new();
		HttpClient httpClient = new HttpClient();
		private string agent = "KretaAPI";
		public Engine(string apiKey = "7856d350-1fda-45f5-822d-e1a2f3f1acf0", string userAgent = "KretaAPI")
		{
			agent = userAgent;
			hmac.Key = Encoding.ASCII.GetBytes("baSsxOwlU1jM");
			httpClient.DefaultRequestHeaders.Add("apiKey", apiKey);
			httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(agent);
		}
		public List<Institute>? Institute()
		{
			string resp = httpClient.GetStringAsync("https://kretaglobalmobileapi2.ekreta.hu:443/api/v3/Institute").Result;
			return JsonSerializer.Deserialize<List<Institute>>(resp);
		}
	}
	public class Account
	{
		public LoginDetails? loginDetails = null;
		public HttpClient client = new();
		private string institute = string.Empty;
		public Account(string instituteCode, string username, string password, string userAgent = "KretaAPI")
		{
			HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Post, "https://idp.e-kreta.hu/connect/token");
			AuthorizationPolicy ap = new(instituteCode, username);
			req.Headers.UserAgent.ParseAdd(userAgent);
			req.Headers.Add("X-Authorizationpolicy-Key", ap.key);
			req.Headers.Add("X-Authorizationpolicy-Version", ap.version);
			req.Headers.Add("X-Authorizationpolicy-Nonce", ap.nonce);
			req.Content = new StringContent("userName=" + username + "&password=" + password + "&institute_code=" + instituteCode + "&grant_type=password&client_id=kreta-ellenorzo-mobile-android", Encoding.UTF8, "application/x-www-form-urlencoded");
			HttpResponseMessage resp = client.Send(req);
			string json = resp.Content.ReadAsStringAsync().Result;
			loginDetails = JsonSerializer.Deserialize<LoginDetails>(json);
			if (loginDetails != null)
			{
				institute = instituteCode;
				client.DefaultRequestHeaders.UserAgent.ParseAdd(userAgent);
				client.DefaultRequestHeaders.Add("Authorization", loginDetails.token_type + " " + loginDetails.access_token);
			}
		}
		public List<Timetable> OrarendElemek(DateTime datumTol, DateTime datumIg)
		{
			if (client.DefaultRequestHeaders.Contains("Authorization"))
			{
				string json = client.GetStringAsync("https://" + institute + ".e-kreta.hu/ellenorzo/V3/Sajat/OrarendElemek?datumTol=" + datumTol.ToUniversalTime().ToString("o", CultureInfo.InvariantCulture) + "&datumIg=" + datumIg.ToUniversalTime().ToString("o", CultureInfo.InvariantCulture)).Result;
				List<Timetable>? tt = JsonSerializer.Deserialize<List<Timetable>>(json);
				if (tt != null)
				{
					return tt;
				}
			}
			return new();
		}
		public List<Mulasztas> Mulasztasok(DateTime? datumTol = null, DateTime? datumIg = null)
		{
			if (client.DefaultRequestHeaders.Contains("Authorization"))
			{
				string url = "https://" + institute + ".e-kreta.hu/ellenorzo/V3/Sajat/Mulasztasok";
				if (datumTol != null)
				{
					url += "?datumTol=" + datumTol.Value.ToUniversalTime().ToString("o", CultureInfo.InvariantCulture);
				}
				if (datumIg != null)
				{
					url += "?datumTol=" + datumIg.Value.ToUniversalTime().ToString("o", CultureInfo.InvariantCulture);
				}
				string json = client.GetStringAsync(url).Result;
				List<Mulasztas>? mulasztasok = JsonSerializer.Deserialize<List<Mulasztas>>(json);
				if (mulasztasok != null)
				{
					return mulasztasok;
				}
			}
			return new();
		}
		public List<Ertekeles> Ertekelesek(DateTime? datumTol = null, DateTime? datumIg = null)
		{
			if (client.DefaultRequestHeaders.Contains("Authorization"))
			{
				string url = "https://" + institute + ".e-kreta.hu/ellenorzo/V3/Sajat/Ertekelesek";
				if (datumTol != null)
				{
					url += "?datumTol=" + datumTol.Value.ToUniversalTime().ToString("o", CultureInfo.InvariantCulture);
				}
				if (datumIg != null)
				{
					url += "?datumTol=" + datumIg.Value.ToUniversalTime().ToString("o", CultureInfo.InvariantCulture);
				}
				string json = client.GetStringAsync(url).Result;
				List <Ertekeles>? ertekelesek = JsonSerializer.Deserialize<List<Ertekeles>>(json);
				if (ertekelesek != null)
				{
					return ertekelesek;
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
				}
			}
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
					url += "?datumTol=" + datumTol.Value.ToString("o", CultureInfo.InvariantCulture);
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
	}
}