using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Signer
	{
		[JsonPropertyName("oktatasiAzonosito")]
		public string? educationId { get; set; }
		[JsonPropertyName("kretaAzonosito")]
		public int id { get; set; }
		[JsonPropertyName("isAlairo")]
		public bool isSigner { get; set; }
		[JsonPropertyName("nev")]
		public string? name { get; set; }
		[JsonPropertyName("titulus")]
		public string? title { get; set; }
	}
}
