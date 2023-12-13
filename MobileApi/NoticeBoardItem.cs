/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class NoticeBoardItem
	{
		[JsonPropertyName("Tartalom")]
		public string? content { get; set; }
		[JsonPropertyName("ErvenyessegVege")]
		public string? expireEndTimeAsString { get; set; }
		[JsonPropertyName("ErvenyessegKezdete")]
		public string? expireStartTimeAsString { get; set; }
		[JsonPropertyName("RogzitoNeve")]
		public string? madeBy { get; set; }
		[JsonPropertyName("Cim")]
		public string? title { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
	}
}
