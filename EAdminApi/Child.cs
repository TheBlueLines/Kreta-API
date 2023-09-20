using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Child
	{
		[JsonPropertyName("oktatasiAzonosito")]
		public long? educationId { get; set; }
		[JsonPropertyName("vezetekNev")]
		public string? firstName { get; set; }
		[JsonPropertyName("keresztNev")]
		public string? lastName { get; set; }
		[JsonPropertyName("osztaly")]
		public string? studentClass { get; set; }
	}
}