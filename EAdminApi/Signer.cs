/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Signer
	{
		[JsonPropertyName("oktatasiAzonosito")]
		public string? educationId { get; set; }
		[JsonPropertyName("kretaAzonosito")]
		public int? id { get; set; }
		[JsonPropertyName("isAlairo")]
		public Boolean? isSigner { get; set; }
		[JsonPropertyName("nev")]
		public string? name { get; set; }
		[JsonPropertyName("titulus")]
		public string? title { get; set; }
	}
}
