/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:32
*/

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
		public Boolean? isAdmin { get; set; }
		[JsonPropertyName("isOsztalyfonok")]
		public Boolean? isClassMaster { get; set; }
		[JsonPropertyName("isTorolt")]
		public Boolean? isDeleted { get; set; }
		[JsonPropertyName("isOsztalyfonokHelyettes")]
		public Boolean? isDeputyClassMaster { get; set; }
		[JsonPropertyName("isIgazgatoHelyettes")]
		public Boolean? isDeputyDirector { get; set; }
		[JsonPropertyName("isIgazgato")]
		public Boolean? isDirector { get; set; }
		[JsonPropertyName("isAlairo")]
		public Boolean? isSignatory { get; set; }
		[JsonPropertyName("isTanar")]
		public Boolean? isTeacher { get; set; }
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
