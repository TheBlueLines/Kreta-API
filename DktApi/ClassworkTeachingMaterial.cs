using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class ClassworkTeachingMaterial
	{
		[JsonPropertyName("feladatId")]
		public long classworkId { get; set; }
		[JsonPropertyName("id")]
		public long id { get; set; }
		[JsonPropertyName("link")]
		public string? link { get; set; }
		[JsonPropertyName("forrasTipusId")]
		public int materialTypeId { get; set; }
		[JsonPropertyName("cim")]
		public string? title { get; set; }
	}
}
