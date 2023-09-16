using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Institute
	{
		[JsonPropertyName("telepules")]
		public string? city { get; set; }
		[JsonPropertyName("kornyezetNev")]
		public string? environmentName { get; set; }
		[JsonPropertyName("id")]
		public string? id { get; set; }
		[JsonPropertyName("azonosito")]
		public string? instituteCode { get; set; }
		[JsonPropertyName("nev")]
		public string? name { get; set; }
		[JsonPropertyName("kretaLink")]
		public string? url { get; set; }
	}
}