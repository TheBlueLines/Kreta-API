using System.Net.Http.Json;
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
		public TemporaryFile createAttachment(Stream stream, string fileName)
		{
			MultipartFormDataContent multipartFormDataContent = new();
			StreamContent streamContent = new(stream);
			multipartFormDataContent.Add(streamContent, "fajl", fileName);
			HttpResponseMessage resp = client.PostAsync("/api/v1/ideiglenesfajlok", multipartFormDataContent).Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<TemporaryFile>(json);
		}
		public HttpContent createRectification(string ugyId, RectificationPost rectificationPost)
		{
			JsonContent jsonContent = JsonContent.Create(rectificationPost, options: Engine.jsonSerializerOptions);
			HttpResponseMessage resp = client.PostAsync($"/api/v1/ugy/kerelmek/{ugyId}", jsonContent).Result;
			return resp.Content;
		}
		public HttpContent createTmgiCase(TmgiCasePost tmgiCasePost)
		{
			JsonContent jsonContent = JsonContent.Create(tmgiCasePost, options: Engine.jsonSerializerOptions);
			HttpResponseMessage resp = client.PostAsync($"/api/v1/ugy/kerelmek", jsonContent).Result;
			return resp.Content;
		}
		public HttpContent deleteMessagePermanently(bool isKuka, params long[] postaladaElemAzonositok)
		{
			string temp = string.Empty;
			foreach (long value in postaladaElemAzonositok)
			{
				temp += "," + postaladaElemAzonositok;
			}
			HttpResponseMessage resp = client.DeleteAsync($"/api/v1/kommunikacio/postaladaelemek/torles?isKuka={isKuka}&postaladaElemAzonositok={temp[1..]}").Result;
			return resp.Content;
		}
		public HttpContent downloadAttachment(string url)
		{
			HttpResponseMessage resp = client.GetAsync($"/api/v1/{url}").Result;
			return resp.Content;
		}
		public List<AccessControlSystemItem> getAccessControlSystemEvents()
		{
			HttpResponseMessage resp = client.GetAsync($"/api/v1/belepteto/kartyaesemenyek/sajat").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<AccessControlSystemItem>>(json);
		}
		public List<KretaClass> getAddressableClasses(string cimzettKod)
		{
			HttpResponseMessage resp = client.GetAsync($"/api/v1/kommunikacio/osztalyok/cimezheto?cimzettKod={cimzettKod}").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<KretaClass>>(json);
		}
		public List<GuardianEAdmin> getAddressableGuardiansForClass(long osztalyKretaAzonosito)
		{
			HttpResponseMessage resp = client.GetAsync($"/api/v1/kreta/gondviselok/osztaly/{osztalyKretaAzonosito}").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<GuardianEAdmin>>(json);
		}
		public List<GuardianEAdmin> getAddressableSzmkRepesentative()
		{
			HttpResponseMessage resp = client.GetAsync($"/api/v1/kommunikacio/szmkkepviselok/cimezheto").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<GuardianEAdmin>>(json);
		}
		public List<AddresseeType> getAddressableType()
		{
			HttpResponseMessage resp = client.GetAsync($"/api/v1/kommunikacio/cimezhetotipusok").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<AddresseeType>>(json);
		}
		public List<AddresseeType> getAddresseeType()
		{
			HttpResponseMessage resp = client.GetAsync($"/api/v1/adatszotarak/cimzetttipusok").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<AddresseeType>>(json);
		}
		public List<EmployeeDetails> getAdministrators()
		{
			HttpResponseMessage resp = client.GetAsync($"/api/v1/kreta/alkalmazottak/adminisztrator").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<EmployeeDetails>>(json);
		}
		public Case getCase(string ugyId)
		{
			HttpResponseMessage resp = client.GetAsync($"/api/v1/ugy/kerelmek/{ugyId}").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<Case>(json);
		}
		public List<Type> getCaseTypes()
		{
			HttpResponseMessage resp = client.GetAsync($"/api/v1/adatszotarak/kerelemtipusok").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<Type>>(json);
		}
		public List<Case> getCases()
		{
			HttpResponseMessage resp = client.GetAsync($"/api/v1/ugy/kerelmek").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<Case>>(json);
		}
		public Child getChildData()
		{
			HttpResponseMessage resp = client.GetAsync($"/api/v1/kreta/gyerekemadatok").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<Child>(json);
		}
		public List<EmployeeDetails> getClassMasters()
		{
			HttpResponseMessage resp = client.GetAsync($"/api/v1/kreta/alkalmazottak/oszalyfonok").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<EmployeeDetails>>(json);
		}
		public CurrentInstitutionDetails getCurrentInstitutionDetails()
		{
			HttpResponseMessage resp = client.GetAsync($"/api/v1/ugy/aktualisIntezmenyAdatok").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<CurrentInstitutionDetails>(json);
		}
		public List<string> getCurrentInstitutionModules()
		{
			HttpResponseMessage resp = client.GetAsync($"/api/v1/intezmenyek/sajat/modulok").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<string>>(json);
		}
		public List<EmployeeDetails> getDirectors()
		{
			HttpResponseMessage resp = client.GetAsync($"/api/v1/kreta/alkalmazottak/igazgatosag").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<EmployeeDetails>>(json);
		}
		public MailboxItem getMessage(long azonosito)
		{
			HttpResponseMessage resp = client.GetAsync($"/api/v1/kommunikacio/postaladaelemek/{azonosito}").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<MailboxItem>(json);
		}
		public MessageLimitations getMessageLimitations()
		{
			HttpResponseMessage resp = client.GetAsync($"/api/v1/kommunikacio/uzenetek/kuldhetok/korlat").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<MessageLimitations>(json);
		}
		public List<MailboxItem> getMessages()
		{
			HttpResponseMessage resp = client.GetAsync($"/api/v1/kommunikacio/postaladaelemek/sajat").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<MailboxItem>>(json);
		}
		public Signer getSigner(int kerelemAzonosito, int kretaAzonosito)
		{
			HttpResponseMessage resp = client.GetAsync($"/api/v1/ugy/alkalmazott/{kerelemAzonosito}/{kretaAzonosito}").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<Signer>(json);
		}
		public Status getStatus()
		{
			HttpResponseMessage resp = client.GetAsync($"/api/v1/status").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<Status>(json);
		}
		public List<Guardian> getSzmk()
		{
			HttpResponseMessage resp = client.GetAsync($"/api/v1/kommunikacio/szmkkepviselok/cimezheto").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<Guardian>>(json);
		}
		public List<EmployeeDetails> getTeachers()
		{
			HttpResponseMessage resp = client.GetAsync($"/api/v1/kreta/alkalmazottak/tanar").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<EmployeeDetails>>(json);
		}
		public List<Type> getTmgiCaseTypes()
		{
			HttpResponseMessage resp = client.GetAsync($"/api/v1/adatszotarak/tmgiigazolastipusok").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<Type>>(json);
		}
		public int getUnreadMessagesCount()
		{
			HttpResponseMessage resp = client.GetAsync($"/api/v1/kommunikacio/postaladaelemek/olvasatlanokszama").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<int>(json);
		}
		public HttpContent readMessage(ReadMessageRequest readMessageRequest)
		{
			JsonContent jsonContent = JsonContent.Create(readMessageRequest, options: Engine.jsonSerializerOptions);
			HttpResponseMessage resp = client.PostAsync($"/api/v1/kommunikacio/postaladaelemek/olvasott", jsonContent).Result;
			return resp.Content;
		}
		public HttpContent sendMessage(Message message)
		{
			JsonContent jsonContent = JsonContent.Create(message, options: Engine.jsonSerializerOptions);
			HttpResponseMessage resp = client.PostAsync($"/api/v1/kommunikacio/uzenetek", jsonContent).Result;
			return resp.Content;
		}
		public HttpContent sendMessageToBin(SendMessageToBinRequest sendMessageToBinRequest)
		{
			JsonContent jsonContent = JsonContent.Create(sendMessageToBinRequest, options: Engine.jsonSerializerOptions);
			HttpResponseMessage resp = client.PostAsync($"/api/v1/kommunikacio/postaladaelemek/kuka", jsonContent).Result;
			return resp.Content;
		}
		public TemporaryFile uploadAttachment(string url, Stream stream, string fileName)
		{
			MultipartFormDataContent multipartFormDataContent = new();
			StreamContent streamContent = new(stream);
			multipartFormDataContent.Add(streamContent, "fajl", fileName);
			HttpResponseMessage resp = client.PostAsync(url, multipartFormDataContent).Result;
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
	public class EAdminException
	{
		public string? uzenet { get; set; }
		public string? hibaAzonosito { get; set; }
		public string? datumUtc { get; set; }
		public bool isBusinessException { get; set; }
	}
}