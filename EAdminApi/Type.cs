using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Type
	{
		[JsonPropertyName("kod")]
		public string? code { get; set; }
		[JsonPropertyName("leiras")]
		public string? description { get; set; }
		[JsonPropertyName("azonosito")]
		public string? id { get; set; }
		[JsonPropertyName("nev")]
		public string? name { get; set; }
		[JsonPropertyName("rovidNev")]
		public string? shortName { get; set; }
	}
}
