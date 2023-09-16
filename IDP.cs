using System.Text.Json;

namespace TTMC.Kréta
{
	public class IDP
	{
		private HttpClient client;
		public IDP(string domain = "e-kreta.hu")
		{
			client = new()
			{
				BaseAddress = new($"https://idp.{domain}")
			};
		}
		public Authentication Login(string instituteCode, string username, string password)
		{
			AuthorizationPolicy authorizationPolicy = new(GetNonce(), instituteCode, username);
			client.DefaultRequestHeaders.UserAgent.ParseAdd("KretaAPI");
			client.DefaultRequestHeaders.Add("X-Authorizationpolicy-Key", authorizationPolicy.key);
			client.DefaultRequestHeaders.Add("X-Authorizationpolicy-Version", authorizationPolicy.version);
			client.DefaultRequestHeaders.Add("X-Authorizationpolicy-Nonce", authorizationPolicy.nonce);
			Dictionary<string, string> keyValuePairs = new() { { "userName", username }, { "password", password }, { "institute_code", instituteCode }, { "grant_type", "password" }, { "client_id", "kreta-ellenorzo-mobile-android" } };
			FormUrlEncodedContent content = new(keyValuePairs);
			HttpResponseMessage resp = client.PostAsync("/connect/token", content).Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<Authentication>(json);
		}
		public Authentication RefreshToken(string instituteCode, string refreshToken)
		{
			Dictionary<string, string> keyValuePairs = new() { { "institute_code", instituteCode }, { "refresh_token", refreshToken }, { "grant_type", "refresh_token" }, { "client_id", "kreta-ellenorzo-mobile-android" } };
			FormUrlEncodedContent content = new(keyValuePairs);
			HttpResponseMessage resp = client.PostAsync("/connect/token", content).Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<Authentication>(json);
		}
		public string GetNonce()
		{
			return client.GetStringAsync("/nonce").Result;
		}
		private T Deserialize<T>(string text)
		{
			if (text.StartsWith('{') && text.EndsWith('}'))
			{
				MobileException? exception = JsonSerializer.Deserialize<MobileException>(text);
				if (exception != null && !string.IsNullOrEmpty(exception.Message))
				{
					throw new Exception(exception.Message);
				}
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
	}
	public class Error
	{
		public string? error { get; set; }
		public string? error_description { get; set; }
	}
}