using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Guardian
	{
		[JsonPropertyName("EmailCim")]
		public string? email { get; set; }
		[JsonPropertyName("IsNincsFelugyeletiJoga")]
		public bool hasParentalRights { get; set; }
		[JsonPropertyName("IsTorvenyesKepviselo")]
		public bool isLegalRepresentative { get; set; }
		[JsonPropertyName("Nev")]
		public string? name { get; set; }
		[JsonPropertyName("Telefonszam")]
		public string? phoneNumber { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
	}
}
