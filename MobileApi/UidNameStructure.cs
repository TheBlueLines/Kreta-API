using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class UidNameStructure
	{
		[JsonPropertyName("Nev")]
		public string? name { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
	}
}