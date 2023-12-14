using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Classwork
	{
		[JsonPropertyName("csatolasEngedelyezesTipusId")]
		public long allowToAttachFileTypeId { get; set; }
		[JsonPropertyName("csoportId")]
		public long classGroupId { get; set; }
		[JsonPropertyName("osztalyId")]
		public long classId { get; set; }
		[JsonPropertyName("osztalyNev")]
		public string? className { get; set; }
		[JsonPropertyName("letrehozasIdeje")]
		public string? creationTimeAsString { get; set; }
		[JsonPropertyName("alkalmazottId")]
		public long employeeId { get; set; }
		[JsonPropertyName("groupId")]
		public string? groupId { get; set; }
		[JsonPropertyName("id")]
		public long id { get; set; }
		[JsonPropertyName("idotartamPerc")]
		public int lengthInMinutes { get; set; }
		[JsonPropertyName("oraDatum")]
		public string? lessonDateAsString { get; set; }
		[JsonPropertyName("oraszam")]
		public long lessonNumber { get; set; }
		[JsonPropertyName("oraIdopont")]
		public string? lessonTimeAsString { get; set; }
		[JsonPropertyName("pontszam")]
		public double score { get; set; }
		[JsonPropertyName("tantargyKategoriaId")]
		public string? subjectCategoryUid { get; set; }
		[JsonPropertyName("tantargyId")]
		public long subjectId { get; set; }
		[JsonPropertyName("tantargyNev")]
		public string? subjectName { get; set; }
		[JsonPropertyName("beadandoTipusId")]
		public long taskTypeId { get; set; }
		[JsonPropertyName("alkalmazottNev")]
		public string? teacherName { get; set; }
		[JsonPropertyName("szoveg")]
		public string? text { get; set; }
		[JsonPropertyName("cim")]
		public string? title { get; set; }
		[JsonPropertyName("egyediId")]
		public string? uniqueId { get; set; }
	}
}
