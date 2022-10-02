namespace TTMC.Kréta
{
	internal class KretaAPI
	{
		public static string login = Kreta.Idp + KretaEndpoints.token;
		public static string nonce = Kreta.Idp + KretaEndpoints.nonce;
		public static string clientId = "kreta-ellenorzo-mobile-android";
		public static string homework(string instituteCode, DateTime datumTol)
		{
			return Kreta.Base(instituteCode) + KretaEndpoints.homework + "?datumTol=" + datumTol.ToString("u").Split(' ')[0];
		}
		public static string notes(string instituteCode)
		{
			return Kreta.Base(instituteCode) + KretaEndpoints.notes;
		}
	}
	internal class Kreta
	{
		public static string Domain = "e-kreta.hu";
		public static string Idp = "https://idp." + Domain;
		public static string Admin = "https://eugyintezes." + Domain;
		public static string Files = "https://files." + Domain;
		public static string Base(string instituteCode)
		{
			return "https://" + instituteCode + "." + Domain;
		}
	}
	internal class KretaEndpoints
	{
		public static string token = "/connect/token";
		public static string nonce = "/nonce";
		public static string notes = "/ellenorzo/V3/Sajat/Feljegyzesek";
		public static string events = "/ellenorzo/V3/Sajat/FaliujsagElemek";
		public static string student = "/ellenorzo/V3/Sajat/TanuloAdatlap";
		public static string grades = "/ellenorzo/V3/Sajat/Ertekelesek";
		public static string absences = "/ellenorzo/V3/Sajat/Mulasztasok";
		public static string groups = "/ellenorzo/V3/Sajat/OsztalyCsoportok";
		public static string groupAverages = "/ellenorzo/V3/Sajat/Ertekelesek/Atlagok/OsztalyAtlagok";
		public static string timetable = "/ellenorzo/V3/Sajat/OrarendElemek";
		public static string exams = "/ellenorzo/V3/Sajat/BejelentettSzamonkeresek";
		public static string homework = "/ellenorzo/V3/Sajat/HaziFeladatok";
		public static string capabilities = "/ellenorzo/V3/Sajat/Intezmenyek";
	}
	internal class AdminEndpoints
	{
		public static string sendMessage = "/api/v1/kommunikacio/uzenetek";
		public static string getAllMessages(string endpoint)
		{
			return "/api/v1/kommunikacio/postaladaelemek/" + endpoint;
		}
		public static string getMessage(ulong id)
		{
			return "/api/v1/kommunikacio/postaladaelemek/" + id;
		}
		public static string recipientCategories = "/api/v1/adatszotarak/cimzetttipusok";
		public static string availableCategories = "/api/v1/kommunikacio/cimezhetotipusok";
		public static string recipientsTeacher = "/api/v1/kreta/alkalmazottak/tanar";
		public static string uploadAttachment = "/ideiglenesfajlok";
		public static string downloadAttachment(string id)
		{
			return "/v1/dokumentumok/uzenetek/" + id;
		}
		public static string trashMessage = "/api/v1/kommunikacio/postaladaelemek/kuka";
		public static string deleteMessage = "/api/v1/kommunikacio/postaladaelemek/torles";
	}
}
