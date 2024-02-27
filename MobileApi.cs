using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

namespace TTMC.Kréta
{
	public class MobileApi
	{
		private HttpClient client;
		public MobileApi(string instituteCode, string accessToken, string? apiKey = "21ff6c25-d1da-4a68-a811-c881a6057463", string domain = "e-kreta.hu")
		{
			client = new()
			{
				BaseAddress = new($"https://{instituteCode}.{domain}")
			};
			if (!string.IsNullOrEmpty(apiKey))
			{
				client.DefaultRequestHeaders.Add("apiKey", apiKey);
			}
			client.DefaultRequestHeaders.Authorization = new("Bearer", accessToken);
		}
		public HttpContent deleteBankAccountNumber()
		{
			HttpResponseMessage resp = client.DeleteAsync($"/ellenorzo/v3/sajat/Bankszamla").Result;
			return resp.Content;
		}
		public HttpContent deleteReservation(string uid)
		{
			HttpResponseMessage resp = client.DeleteAsync($"/ellenorzo/v3/sajat/Fogadoorak/Idopontok/Jelentkezesek/{uid}").Result;
			return resp.Content;
		}
		public HttpContent downloadAttachment(string uid)
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/sajat/Csatolmany/{uid}").Result;
			return resp.Content;
		}
		public List<AnnouncedTest> GetAnnouncedTests(DateTime? fromDate = null, DateTime? toDate = null)
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/Sajat/BejelentettSzamonkeresek" + BuildQuery(fromDate, toDate)).Result;
			return Deserialize<List<AnnouncedTest>>(resp);
		}
		public List<ClassAverage> GetClassAverage(string taskUid, string? subjectUid = null)
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/sajat/Ertekelesek/Atlagok/OsztalyAtlagok?oktatasiNevelesiFeladatUid={taskUid}" + (subjectUid == null ? string.Empty : "&tantargyUid=" + subjectUid)).Result;
			return Deserialize<List<ClassAverage>>(resp);
		}
		public List<ClassMaster> GetClassMaster(string? uids = null)
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/felhasznalok/Alkalmazottak/Tanarok/Osztalyfonokok" + (uids == null ? string.Empty : "?Uids=" + uids)).Result;
			return Deserialize<List<ClassMaster>>(resp);
		}
		public ConsultingHour GetConsultingHour(string uid)
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/sajat/Fogadoorak/{uid}").Result;
			return Deserialize<ConsultingHour>(resp);
		}
		public List<ConsultingHourList> GetConsultingHours(DateTime? fromDate = null, DateTime? toDate = null)
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/sajat/Fogadoorak" + BuildQuery(fromDate, toDate)).Result;
			return Deserialize<List<ConsultingHourList>>(resp);
		}
		public bool GetDeviceGivenState()
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/TargyiEszkoz/IsEszkozKiosztva").Result;
			string text = resp.Content.ReadAsStringAsync().Result;
			if (resp.StatusCode == HttpStatusCode.OK && bool.TryParse(text, out bool check))
			{
				return check;
			}
			throw new(text);
		}
		public List<Evaluation> GetEvaluations(DateTime? fromDate = null, DateTime? toDate = null)
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/sajat/Ertekelesek" + BuildQuery(fromDate, toDate)).Result;
			return Deserialize<List<Evaluation>>(resp);
		}
		public List<Group> GetGroups()
		{
			HttpResponseMessage resp = client.GetAsync("/ellenorzo/v3/sajat/OsztalyCsoportok").Result;
			return Deserialize<List<Group>>(resp);
		}
		public Guardian4T GetGuardian4T()
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/sajat/GondviseloAdatlap").Result;
			return Deserialize<Guardian4T>(resp);
		}
		public List<Homework> GetHomeworks(DateTime? fromDate = null, DateTime? toDate = null)
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/Sajat/HaziFeladatok" + BuildQuery(fromDate, toDate)).Result;
			return Deserialize<List<Homework>>(resp);
		}
		public Homework GetHomework(string id)
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/Sajat/HaziFeladatok/{id}").Result;
			return Deserialize<Homework>(resp);
		}
		public List<LepEvent> GetLEPEvents()
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/Lep/Eloadasok").Result;
			return Deserialize<List<LepEvent>>(resp);
		}
		public Lesson GetLesson(string uid)
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/Sajat/OrarendElem?orarendElemUid={uid}").Result;
			return Deserialize<Lesson>(resp);
		}
		public List<Lesson> GetLessons(DateTime? fromDate = null, DateTime? toDate = null)
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/Sajat/OrarendElem" + BuildQuery(fromDate, toDate)).Result;
			return Deserialize<List<Lesson>>(resp);
		}
		public List<Note> GetNotes(DateTime? fromDate = null, DateTime? toDate = null)
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/Feljegyzesek" + BuildQuery(fromDate, toDate)).Result;
			return Deserialize<List<Note>>(resp);
		}
		public List<NoticeBoardItem> GetNoticeBoardItems()
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/FaliujsagElemek").Result;
			return Deserialize<List<NoticeBoardItem>>(resp);
		}
		public List<Omission> GetOmissions(DateTime? fromDate = null, DateTime? toDate = null)
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/Mulasztasok" + BuildQuery(fromDate, toDate)).Result;
			return Deserialize<List<Omission>>(resp);
		}
		public HttpContent GetRegistrationState()
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/TargyiEszkoz/IsRegisztralt").Result;
			return resp.Content;
		}
		public SchoolYearCalendarEntry GetSchoolYearCalendar()
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/sajat/Intezmenyek/TanevRendjeElemek").Result;
			return Deserialize<SchoolYearCalendarEntry>(resp);
		}
		public Student GetStudent()
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/sajat/TanuloAdatlap").Result;
			return Deserialize<Student>(resp);
		}
		public List<SubjectAverage> GetSubjectAverage(string uid)
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/sajat/Ertekelesek/Atlagok/TantargyiAtlagok?oktatasiNevelesiFeladatUid={uid}").Result;
			return Deserialize<List<SubjectAverage>>(resp);
		}
		public TeszekRegistration getTeszekRegistration()
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/TargyiEszkoz/Regisztracio").Result;
			return Deserialize<TeszekRegistration>(resp);
		}
		public List<TimeTableWeek> GetTimeTableWeeks(DateTime fromDate, DateTime toDate)
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/sajat/Intezmenyek/Hetirendek/Orarendi?orarendElemKezdoNapDatuma={fromDate.ToString("s")}&orarendElemVegNapDatuma={toDate.ToString("s")}").Result;
			return Deserialize<List<TimeTableWeek>>(resp);
		}
		public HttpContent postBankAccountNumber(BankAccountNumberPost bankAccountNumber)
		{
			JsonContent jsonContent = JsonContent.Create(bankAccountNumber, options: Engine.jsonSerializerOptions);
			HttpResponseMessage resp = client.PostAsync($"/ellenorzo/v3/sajat/Bankszamla", jsonContent).Result;
			return resp.Content;
		}
		public HttpContent postContact(string email, string telefonszam)
		{
			List<KeyValuePair<string, string>> keyValuePairs = new() { new("email", email), new("telefonszam", telefonszam) };
			FormUrlEncodedContent formUrlEncodedContent = new(keyValuePairs);
			HttpResponseMessage resp = client.PostAsync($"/ellenorzo/v3/sajat/Elerhetoseg", formUrlEncodedContent).Result;
			return resp.Content;
		}
		public HttpContent postCovidForm()
		{
			HttpResponseMessage resp = client.PostAsync($"/ellenorzo/v3/Bejelentes/Covid", null).Result;
			return resp.Content;
		}
		public HttpContent postReservation(string uid)
		{
			HttpResponseMessage resp = client.PostAsync($"/ellenorzo/v3/sajat/Fogadoorak/Idopontok/Jelentkezesek/{uid}", null).Result;
			return resp.Content;
		}
		public HttpContent postTeszekRegistration(Guardian4TPost guardian4TPost)
		{
			JsonContent jsonContent = JsonContent.Create(guardian4TPost, options: Engine.jsonSerializerOptions);
			HttpResponseMessage resp = client.PostAsync($"/ellenorzo/v3/TargyiEszkoz/Regisztracio", jsonContent).Result;
			return resp.Content;
		}
		public HttpContent updateGuardian4T(Guardian4TPost guardian4TPost)
		{
			JsonContent jsonContent = JsonContent.Create(guardian4TPost, options: Engine.jsonSerializerOptions);
			HttpResponseMessage resp = client.PutAsync($"/ellenorzo/v3/sajat/GondviseloAdatlap", jsonContent).Result;
			return resp.Content;
		}
		public string updateLepEventPermission(LepEventGuardianPermissionPost lepEventGuardianPermissionPost)
		{
			JsonContent jsonContent = JsonContent.Create(lepEventGuardianPermissionPost, options: Engine.jsonSerializerOptions);
			HttpResponseMessage resp = client.PostAsync($"/ellenorzo/v3/Lep/Eloadasok/GondviseloEngedelyezes", jsonContent).Result;
			return resp.Content.ReadAsStringAsync().Result;
		}
		private T Deserialize<T>(HttpResponseMessage response)
		{
			string json = response.Content.ReadAsStringAsync().Result;
			if (response.StatusCode == HttpStatusCode.OK)
			{
				T? temp = JsonSerializer.Deserialize<T>(json);
				if (temp != null)
				{
					return temp;
				}
			}
			else if (json.StartsWith('{') && json.EndsWith('}'))
			{
				Error? error = JsonSerializer.Deserialize<Error>(json);
				if (error != null && !string.IsNullOrEmpty(error.error))
				{
					throw new(error.error);
				}
			}
			throw new(json);
		}
		private string BuildQuery(DateTime? fromDate, DateTime? toDate)
		{
			string query = "?";
			if (fromDate != null)
			{
				query += "datumTol=" + fromDate.Value.ToString("s") + "&";
			}
			if (toDate != null)
			{
				query += "datumIg=" + toDate.Value.ToString("s") + "&";
			}
			return query[..^1];
		}
	}
	public class MobileException
	{
		public string? ExceptionId { get; set; }
		public string? ExceptionType { get; set; }
		public string? Message { get; set; }
		public List<MobileExceptionX>? ErrorList { get; set; }
	}
	public class MobileExceptionX
	{
		public string? PropertyName { get; set; }
		public string? Message { get; set; }
		public string? ExceptionType { get; set; }
	}
}