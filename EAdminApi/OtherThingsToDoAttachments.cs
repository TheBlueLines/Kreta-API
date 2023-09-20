using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class OtherThingsToDoAttachments
	{
		[JsonPropertyName("fajl")]
		public File? file { get; set; }
		[JsonPropertyName("fajlNev")]
		public string? fileName { get; set; }
		[JsonPropertyName("azonosito")]
		public int? id { get; set; }
		[JsonPropertyName("iktatoszam")]
		public string? registrationNumber { get; set; }
	}
}