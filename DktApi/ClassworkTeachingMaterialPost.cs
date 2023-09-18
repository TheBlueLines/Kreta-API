using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class ClassworkTeachingMaterialPost
	{
		[JsonPropertyName("osztalyId")]
		public long? classId { get; set; }
		[JsonPropertyName("feladatId")]
		public long classworkId { get; set; }
		[JsonPropertyName("datum")]
		public string? date { get; set; }
		[JsonPropertyName("alkalmazottId")]
		public long employeeId { get; set; }
		[JsonPropertyName("csoportId")]
		public long? groupId { get; set; }
		[JsonPropertyName("oraszam")]
		public long lessonNumber { get; set; }
		[JsonPropertyName("tantargyId")]
		public long subjectId { get; set; }
		[JsonPropertyName("idopont")]
		public string? time { get; set; }
	}
}