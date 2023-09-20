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
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<AnnouncedTest>>(json);
		}
		public List<ClassAverage> GetClassAverage(string taskUid, string? subjectUid = null)
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/sajat/Ertekelesek/Atlagok/OsztalyAtlagok?oktatasiNevelesiFeladatUid={taskUid}" + (subjectUid == null ? string.Empty : "&tantargyUid=" + subjectUid)).Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<ClassAverage>>(json);
		}
		public List<ClassMaster> GetClassMaster(string? uids = null)
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/felhasznalok/Alkalmazottak/Tanarok/Osztalyfonokok" + (uids == null ? string.Empty : "?Uids=" + uids)).Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<ClassMaster>>(json);
		}
		public ConsultingHour GetConsultingHour(string uid)
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/sajat/Fogadoorak/{uid}").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<ConsultingHour>(json);
		}
		public List<ConsultingHourList> GetConsultingHours(DateTime? fromDate = null, DateTime? toDate = null)
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/sajat/Fogadoorak" + BuildQuery(fromDate, toDate)).Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<ConsultingHourList>>(json);
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
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<Evaluation>>(json);
		}
		public List<Group> GetGroups()
		{
			HttpResponseMessage resp = client.GetAsync("/ellenorzo/v3/sajat/OsztalyCsoportok").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<Group>>(json);
		}
		public Guardian4T GetGuardian4T()
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/sajat/GondviseloAdatlap").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<Guardian4T>(json);
		}
		public List<Homework> GetHomeworks(DateTime? fromDate = null, DateTime? toDate = null)
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/Sajat/HaziFeladatok" + BuildQuery(fromDate, toDate)).Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<Homework>>(json);
		}
		public Homework GetHomework(string id)
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/Sajat/HaziFeladatok/{id}").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<Homework>(json);
		}
		public List<LepEvent> GetLEPEvents()
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/Lep/Eloadasok").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<LepEvent>>(json);
		}
		public Lesson GetLesson(string uid)
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/Sajat/OrarendElem?orarendElemUid={uid}").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<Lesson>(json);
		}
		public List<Lesson> GetLessons(DateTime? fromDate = null, DateTime? toDate = null)
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/Sajat/OrarendElem" + BuildQuery(fromDate, toDate)).Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<Lesson>>(json);
		}
		public List<Note> GetNotes(DateTime? fromDate = null, DateTime? toDate = null)
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/Feljegyzesek" + BuildQuery(fromDate, toDate)).Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<Note>>(json);
		}
		public List<NoticeBoardItem> GetNoticeBoardItems()
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/FaliujsagElemek").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<NoticeBoardItem>>(json);
		}
		public List<Omission> GetOmissions(DateTime? fromDate = null, DateTime? toDate = null)
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/Mulasztasok" + BuildQuery(fromDate, toDate)).Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<Omission>>(json);
		}
		public HttpContent GetRegistrationState()
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/TargyiEszkoz/IsRegisztralt").Result;
			return resp.Content;
		}
		public SchoolYearCalendarEntry GetSchoolYearCalendar()
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/sajat/Intezmenyek/TanevRendjeElemek").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<SchoolYearCalendarEntry>(json);
		}
		public Student GetStudent()
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/sajat/TanuloAdatlap").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
            return Deserialize<Student>(json);
		}
		public List<SubjectAverage> GetSubjectAverage(string uid)
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/sajat/Ertekelesek/Atlagok/TantargyiAtlagok?oktatasiNevelesiFeladatUid={uid}").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<SubjectAverage>>(json);
		}
		public List<TimeTableWeek> GetTimeTableWeeks(DateTime fromDate, DateTime toDate)
		{
			HttpResponseMessage resp = client.GetAsync($"/ellenorzo/v3/sajat/Intezmenyek/Hetirendek/Orarendi?orarendElemKezdoNapDatuma={fromDate.ToString("s")}&orarendElemVegNapDatuma={toDate.ToString("s")}").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return Deserialize<List<TimeTableWeek>>(json);
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
		private T Deserialize<T>(string json)
		{
			if (json.StartsWith('{') && json.EndsWith('}'))
			{
				Error? error = JsonSerializer.Deserialize<Error>(json);
				if (error != null && !string.IsNullOrEmpty(error.error))
				{
					throw new(error.error);
				}
			}
			try
			{
				T? temp = JsonSerializer.Deserialize<T>(json);
				if (temp != null)
				{
					return temp;
				}
			}
			catch { }
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