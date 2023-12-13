/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

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
