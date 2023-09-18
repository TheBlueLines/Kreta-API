using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class LanguageSubTask
	{
		[JsonPropertyName("idotartamPerc")]
		public long durationInMinutes { get; set; }
		[JsonPropertyName("id")]
		public long id { get; set; }
		[JsonPropertyName("xeropanSzazalek")]
		public long? percent { get; set; }
		[JsonPropertyName("xeropanMegoldasBekuldesiIdeje")]
		public string? submissionDateAsString { get; set; }
		[JsonPropertyName("xeropanMegoldassalToltottIdoPerc")]
		public long? timeSpent { get; set; }
		[JsonPropertyName("cim")]
		public string? title { get; set; }
		[JsonPropertyName("xeropanLessonId")]
		public long xeropanLessonId { get; set; }
	}
}