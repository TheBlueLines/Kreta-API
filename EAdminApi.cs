using System.Text.Json;

namespace TTMC.Kréta
{
	public class EAdminApi
	{
		private HttpClient client;
		public EAdminApi(string accessToken, string domain = "e-kreta.hu")
		{
			client = new()
			{
				BaseAddress = new($"https://eugyintezes.{domain}")
			};
			client.DefaultRequestHeaders.Add("X-Uzenet-Lokalizacio", "hu-HU");
			client.DefaultRequestHeaders.Authorization = new("Bearer", accessToken);
		}
		private TemporaryFile uploadAttachment(string url, Stream stream, string fileName)
		{
			MultipartFormDataContent multipartFormDataContent = new();
			StreamContent streamContent = new(stream);
			multipartFormDataContent.Add(streamContent, "fajl", fileName);
			HttpResponseMessage resp = client.PostAsync(url, multipartFormDataContent).Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<TemporaryFile>(json);
		}
		private TemporaryFile uploadAttachment(string url, byte[] data, string fileName)
		{
			MultipartFormDataContent multipartFormDataContent = new();
			ByteArrayContent byteArrayContent = new(data);
			multipartFormDataContent.Add(byteArrayContent, "fajl", fileName);
			HttpResponseMessage resp = client.PostAsync(url, multipartFormDataContent).Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<TemporaryFile>(json);
		}
		private TemporaryFile createAttachment(Stream stream, string fileName)
		{
			MultipartFormDataContent multipartFormDataContent = new();
			StreamContent streamContent = new(stream);
			multipartFormDataContent.Add(streamContent, "fajl", fileName);
			HttpResponseMessage resp = client.PostAsync("api/v1/ideiglenesfajlok", multipartFormDataContent).Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<TemporaryFile>(json);
		}
		private TemporaryFile createAttachment(byte[] data, string fileName)
		{
			MultipartFormDataContent multipartFormDataContent = new();
			ByteArrayContent byteArrayContent = new(data);
			multipartFormDataContent.Add(byteArrayContent, "fajl", fileName);
			HttpResponseMessage resp = client.PostAsync("api/v1/ideiglenesfajlok", multipartFormDataContent).Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<TemporaryFile>(json);
		}
		private T Deserialize<T>(string json)
		{
			try
			{
				if (json.StartsWith('{') && json.EndsWith('}'))
				{
					EAdminException? eAdminException = JsonSerializer.Deserialize<EAdminException>(json);
					if (eAdminException != null)
					{
						throw new(eAdminException.uzenet);
					}
				}
				T? temp = JsonSerializer.Deserialize<T>(json);
				if (temp != null)
				{
					return temp;
				}
				throw new("Unknown error");
			}
			catch
			{
				throw new(json);
			}
		}
	}
	public class TemporaryFile
	{
		public string? fajlAzonosito { get; set; }
		public string? utvonal { get; set; }
		public long fajlMeretByteLength { get; set; }
	}
	public class EAdminException
	{
		public string? uzenet { get; set; }
		public string? hibaAzonosito { get; set; }
		public string? datumUtc { get; set; }
		public bool isBusinessException { get; set; }
	}
}