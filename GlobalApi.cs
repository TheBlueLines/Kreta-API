using System.Text.Json;

namespace TTMC.Kréta
{
	public class GlobalApi
	{
		private HttpClient client;
		public GlobalApi(string domain = "e-kreta.hu")
		{
			client = new()
			{
				BaseAddress = new($"https://kretaglobalapi.{domain}")
			};
		}
		public List<Institute> GetInstitutes()
		{
			HttpResponseMessage resp = client.GetAsync("/intezmenyek/kreta/publikus").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<Institute>>(json);
		}
		private T Deserialize<T>(string json)
		{
			try
			{
				T? temp = JsonSerializer.Deserialize<T>(json);
				if (temp != null)
				{
					return temp;
				}
				throw new(json);
			}
			catch
			{
				throw new(json);
			}
		}
	}
}