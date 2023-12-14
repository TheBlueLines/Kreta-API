using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class SchoolClass
	{
		[JsonPropertyName("OktatasNevelesiKategoria")]
		public ValueDescriptor? category { get; set; }
		[JsonPropertyName("Nev")]
		public string? name { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
	}
}
