/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Guardian
	{
		[JsonPropertyName("EmailCim")]
		public string? email { get; set; }
		[JsonPropertyName("IsTorvenyesKepviselo")]
		public Boolean? isLegalRepresentative { get; set; }
		[JsonPropertyName("Nev")]
		public string? name { get; set; }
		[JsonPropertyName("Telefonszam")]
		public string? phoneNumber { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
	}
}
