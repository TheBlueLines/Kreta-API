using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Group
	{
		[JsonPropertyName("OktatasNevelesiKategoria")]
		public ValueDescriptor? category { get; set; }
		[JsonPropertyName("OsztalyFonok")]
		public UidStructure? classMaster { get; set; }
		[JsonPropertyName("OsztalyFonokHelyettes")]
		public UidStructure? classMasterAssistant { get; set; }
		[JsonPropertyName("OktatasNevelesiFeladat")]
		public ValueDescriptor? educationType { get; set; }
		[JsonPropertyName("IsAktiv")]
		public bool isActive { get; set; }
		[JsonPropertyName("Nev")]
		public string? name { get; set; }
		[JsonPropertyName("OktatasNevelesiFeladatSortIndex")]
		public int sortIndex { get; set; }
		[JsonPropertyName("Tipus")]
		public string? type { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
	}
}
