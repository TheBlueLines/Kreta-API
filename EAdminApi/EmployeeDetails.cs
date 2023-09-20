using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class EmployeeDetails
	{
		[JsonPropertyName("osztalyHelyettes")]
		public string? classSubstitute { get; set; }
		[JsonPropertyName("osztalyHelyettesKretaAzonosito")]
		public long? classSubstituteKretaId { get; set; }
		[JsonPropertyName("oktatasiAzonosito")]
		public string? educatedId { get; set; }
		[JsonPropertyName("osztaly")]
		public string? educationClass { get; set; }
		[JsonPropertyName("isAdmin")]
		public bool? isAdmin { get; set; }
		[JsonPropertyName("isOsztalyfonok")]
		public bool? isClassMaster { get; set; }
		[JsonPropertyName("isTorolt")]
		public bool? isDeleted { get; set; }
		[JsonPropertyName("isOsztalyfonokHelyettes")]
		public bool? isDeputyClassMaster { get; set; }
		[JsonPropertyName("isIgazgatoHelyettes")]
		public bool? isDeputyDirector { get; set; }
		[JsonPropertyName("isIgazgato")]
		public bool? isDirector { get; set; }
		[JsonPropertyName("isAlairo")]
		public bool? isSignatory { get; set; }
		[JsonPropertyName("isTanar")]
		public bool? isTeacher { get; set; }
		[JsonPropertyName("osztalyKretaAzonosito")]
		public long? kretaClassId { get; set; }
		[JsonPropertyName("kretaAzonosito")]
		public long? kretaId { get; set; }
		[JsonPropertyName("nev")]
		public string? name { get; set; }
		[JsonPropertyName("titulus")]
		public string? title { get; set; }
	}
}