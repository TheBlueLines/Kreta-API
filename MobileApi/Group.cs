/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

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
		public bool? isActive { get; set; }
		[JsonPropertyName("Nev")]
		public string? name { get; set; }
		[JsonPropertyName("OktatasNevelesiFeladatSortIndex")]
		public int? sortIndex { get; set; }
		[JsonPropertyName("Tipus")]
		public string? type { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
	}
}
