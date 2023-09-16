using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Guardian4T
	{
		[JsonPropertyName("EmailCim")]
		public string? email { get; set; }
		[JsonPropertyName("IsTorvenyesKepviselo")]
		public bool? isLegalRepresentative { get; set; }
		[JsonPropertyName("Nev")]
		public string? name { get; set; }
		[JsonPropertyName("Telefonszam")]
		public string? phoneNumber { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
	}
}