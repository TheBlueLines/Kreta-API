using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class ValueDescriptor
	{
		[JsonPropertyName("Leiras")]
		public string? description { get; set; }
		[JsonPropertyName("Nev")]
		public string? name { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
	}
}
