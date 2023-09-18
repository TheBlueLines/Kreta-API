using System.Net.Http.Json;
using System.Text.Json;

namespace TTMC.Kréta
{
	public class DktApi
	{
		private HttpClient client;
		public DktApi(string accessToken, string acceptLanguage = "hu-HU", string? apiKey = "21ff6c25-d1da-4a68-a811-c881a6057463", string domain = "e-kreta.hu")
		{
			client = new()
			{
				BaseAddress = new($"https://kretadktapi.{domain}")
			};
			if (!string.IsNullOrEmpty(apiKey))
			{
				client.DefaultRequestHeaders.Add("apiKey", apiKey);
			}
			client.DefaultRequestHeaders.Add("Accept-Language", acceptLanguage);
			client.DefaultRequestHeaders.Authorization = new("Bearer", accessToken);
		}
		public HttpContent deleteHomeworkSolutionAttachment(string haziFeladatBeadasId, string id)
		{
			HttpResponseMessage resp = client.DeleteAsync($"/dktapi/intezmenyek/tanulok/orak/hazifeladatok/beadasok/{haziFeladatBeadasId}/fajlok/{id}").Result;
			return resp.Content;
		}
		public HttpContent deleteSolutionAttachment(string oraiFeladatBeadasId, string id)
		{
			HttpResponseMessage resp = client.DeleteAsync($"/dktapi/intezmenyek/tanulok/orak/oraifeladatok/beadasok/{oraiFeladatBeadasId}/fajlok/{id}").Result;
			return resp.Content;
		}
		public Classwork? getClasswork(string oraiFeladatId)
		{
			HttpResponseMessage resp = client.GetAsync($"/dktapi/intezmenyek/tanulok/orak/oraifeladatok/{oraiFeladatId}").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return JsonSerializer.Deserialize<Classwork>(json);
		}
		public string getClassworkAttachmentUrl(string oraiFeladatId, string id)
		{
			HttpResponseMessage resp = client.GetAsync($"/dktapi/intezmenyek/tanulok/orak/oraifeladatok/{oraiFeladatId}/fajlok/{id}/url").Result;
			return resp.Content.ReadAsStringAsync().Result;
		}
		public List<ClassworkAttachment>? getClassworkAttachments(string id)
		{
			HttpResponseMessage resp = client.GetAsync($"/dktapi/intezmenyek/tanulok/orak/oraifeladatok/{id}/fajlok").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return JsonSerializer.Deserialize<List<ClassworkAttachment>>(json);
		}
		public List<Classwork>? getClassworkGroups(string groupId)
		{
			HttpResponseMessage resp = client.GetAsync($"/dktapi/intezmenyek/tanulok/orak/oraifeladatok/groupok/{groupId}").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return JsonSerializer.Deserialize<List<Classwork>>(json);
		}
		public string getClassworkSolutionAttachmentUrl(string oraiFeladatBeadasId, string id)
		{
			HttpResponseMessage resp = client.GetAsync($"/dktapi/intezmenyek/tanulok/orak/oraifeladatok/beadasok/{oraiFeladatBeadasId}/fajlok/{id}/url").Result;
			return resp.Content.ReadAsStringAsync().Result;
		}
		public List<ClassworkTeachingMaterial>? getClassworkTeachingMaterial(ClassworkTeachingMaterialPost classworkTeachingMaterialPost)
		{
			JsonContent jsonContent = JsonContent.Create(classworkTeachingMaterialPost, options: GlobalApi.jsonSerializerOptions);
			HttpResponseMessage resp = client.PostAsync($"/dktapi/intezmenyek/tanulok/orak/tananyagok", jsonContent).Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return JsonSerializer.Deserialize<List<ClassworkTeachingMaterial>>(json);
		}
		public string getHomeworkSolutionAttachmentUrl(string haziFeladatBeadasId, string id)
		{
			HttpResponseMessage resp = client.GetAsync($"/dktapi/intezmenyek/tanulok/orak/hazifeladatok/beadasok/{haziFeladatBeadasId}/fajlok/{id}/url").Result;
			return resp.Content.ReadAsStringAsync().Result;
		}
		public List<HomeworkSolutionAttachment>? getHomeworkSolutionAttachments(string haziFeladatBeadasId)
		{
			HttpResponseMessage resp = client.GetAsync($"/dktapi/intezmenyek/tanulok/orak/hazifeladatok/beadasok/{haziFeladatBeadasId}/fajlok").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return JsonSerializer.Deserialize<List<HomeworkSolutionAttachment>>(json);
		}
		public LanguageTask? getLanguageTask(string groupId)
		{
			HttpResponseMessage resp = client.GetAsync($"/dktapi/intezmenyek/tanulok/orak/nyelvifeladatok/{groupId}").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return JsonSerializer.Deserialize<LanguageTask>(json);
		}
		public LanguageTaskSubmission? getLanguageTaskSubmission(string groupId)
		{
			HttpResponseMessage resp = client.GetAsync($"/dktapi/intezmenyek/tanulok/orak/nyelvifeladatok/groupok/{groupId}/beadas").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return JsonSerializer.Deserialize<LanguageTaskSubmission>(json);
		}
		public List<ClassworkSolutionAttachment>? getSolutionAttachments(string beadasId)
		{
			HttpResponseMessage resp = client.GetAsync($"/dktapi/intezmenyek/tanulok/orak/oraifeladatok/beadasok/{beadasId}/fajlok").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return JsonSerializer.Deserialize<List<ClassworkSolutionAttachment>>(json);
		}
		public SubmittedClasswork? getSubmittedClasswork(string oraiFeladatId)
		{
			HttpResponseMessage resp = client.GetAsync($"/dktapi/intezmenyek/tanulok/orak/oraifeladatok/{oraiFeladatId}/beadas").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return JsonSerializer.Deserialize<SubmittedClasswork>(json);
		}
		public SubmittedHomework? getSubmittedHomework(string haziFeladatId)
		{
			HttpResponseMessage resp = client.GetAsync($"/dktapi/intezmenyek/tanulok/orak/hazifeladatok/{haziFeladatId}/beadas").Result;
			string json = resp.Content.ReadAsStringAsync().Result;
			return JsonSerializer.Deserialize<SubmittedHomework>(json);
		}
		public string putSaveSolution(string beadasId, ClassworkSolutionPut classworkSolutionPut)
		{
			JsonContent jsonContent = JsonContent.Create(classworkSolutionPut, options: GlobalApi.jsonSerializerOptions);
			HttpResponseMessage resp = client.PutAsync($"/dktapi/intezmenyek/tanulok/orak/oraifeladatok/beadasok/{beadasId}", jsonContent).Result;
			return resp.Content.ReadAsStringAsync().Result;
		}
		public HttpContent saveHomeworkAttachment(string haziFeladatBeadasId, HomeworkSolutionAttachmentPost homeworkSolutionAttachmentPost)
		{
			JsonContent jsonContent = JsonContent.Create(homeworkSolutionAttachmentPost, options: GlobalApi.jsonSerializerOptions);
			HttpResponseMessage resp = client.PostAsync($"/dktapi/intezmenyek/tanulok/orak/hazifeladatok/beadasok/{haziFeladatBeadasId}/fajlok/veglegesites", jsonContent).Result;
			return resp.Content;
		}
		public string saveHomeworkSolution(string haziFeladatId, HomeworkSolutionPut homeworkSolutionPut)
		{
			JsonContent jsonContent = JsonContent.Create(homeworkSolutionPut, options: GlobalApi.jsonSerializerOptions);
			HttpResponseMessage resp = client.PutAsync($"/dktapi/intezmenyek/tanulok/orak/hazifeladatok/beadasok/{haziFeladatId}", jsonContent).Result;
			return resp.Content.ReadAsStringAsync().Result;
		}
		public HttpContent saveSolutionAttachment(string oraiFeladatBeadasId, ClassworkSolutionAttachmentPost classworkSolutionAttachmentPost)
		{
			JsonContent jsonContent = JsonContent.Create(classworkSolutionAttachmentPost, options: GlobalApi.jsonSerializerOptions);
			HttpResponseMessage resp = client.PostAsync($"/dktapi/intezmenyek/tanulok/orak/oraifeladatok/beadasok/{oraiFeladatBeadasId}/fajlok/veglegesites", jsonContent).Result;
			return resp.Content;
		}
		public string submitClassworkSolution(string beadasId)
		{
			HttpResponseMessage resp = client.GetAsync($"/dktapi/intezmenyek/tanulok/orak/oraifeladatok/beadasok/{beadasId}/beadas").Result;
			return resp.Content.ReadAsStringAsync().Result;
		}
		public string submitHomeworkSolution(string haziFeladatId)
		{
			HttpResponseMessage resp = client.GetAsync($"/dktapi/intezmenyek/tanulok/orak/hazifeladatok/beadasok/{haziFeladatId}/beadas").Result;
			return resp.Content.ReadAsStringAsync().Result;
		}
	}
}