using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class ClassworkSolutionAttachment
	{
		[JsonPropertyName("kiterjesztes")]
		public string? extension { get; set; }
		[JsonPropertyName("fajlNev")]
		public string? fileName { get; set; }
		[JsonPropertyName("id")]
		public long id { get; set; }
		[JsonPropertyName("nev")]
		public string? name { get; set; }
		[JsonPropertyName("feladatBeadasId")]
		public long submittedClassworkId { get; set; }
		[JsonPropertyName("egyediId")]
		public string? uniqueId { get; set; }
	}
}
