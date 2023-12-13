/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:32
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class HomeworkSolutionAttachment
	{
		[JsonPropertyName("kiterjesztes")]
		public string? extension { get; set; }
		[JsonPropertyName("fajlNev")]
		public string? fileName { get; set; }
		[JsonPropertyName("id")]
		public long? id { get; set; }
		[JsonPropertyName("nev")]
		public string? name { get; set; }
		[JsonPropertyName("feladatBeadasId")]
		public long? submittedHomeworkId { get; set; }
		[JsonPropertyName("egyediId")]
		public string? uniqueId { get; set; }
		[JsonPropertyName("feltoltoAlkalmazottId")]
		public long? uploaderEmployeeId { get; set; }
		[JsonPropertyName("feltoltoTanuloId")]
		public long? uploaderStudentId { get; set; }
	}
}
