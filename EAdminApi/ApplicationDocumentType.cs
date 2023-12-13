/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:32
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class ApplicationDocumentType
	{
		[JsonPropertyName("kod")]
		public string? code { get; set; }
		[JsonPropertyName("leiras")]
		public string? description { get; set; }
		[JsonPropertyName("dokumentumSablonNev")]
		public string? documentTemplateName { get; set; }
		[JsonPropertyName("dokumentumSablonUtvonal")]
		public string? documentTemplatePath { get; set; }
		[JsonPropertyName("azonosito")]
		public string? id { get; set; }
		[JsonPropertyName("nev")]
		public string? name { get; set; }
		[JsonPropertyName("rovidNev")]
		public string? shortName { get; set; }
	}
}
