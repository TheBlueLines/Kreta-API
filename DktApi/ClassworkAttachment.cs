using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class ClassworkAttachment
	{
		[JsonPropertyName("feladatId")]
		public long classworkId { get; set; }
		[JsonPropertyName("kiterjesztes")]
		public string? extension { get; set; }
		[JsonPropertyName("fajlNev")]
		public string? fileName { get; set; }
		[JsonPropertyName("id")]
		public long id { get; set; }
		[JsonPropertyName("nev")]
		public string? name { get; set; }
		[JsonPropertyName("egyediId")]
		public string? uniqueId { get; set; }
	}
}
