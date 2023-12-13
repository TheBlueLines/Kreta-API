/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:32
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class AccessControlSystemItem
	{
		[JsonPropertyName("megjegyzes")]
		public string? commentText { get; set; }
		[JsonPropertyName("irany")]
		public string? directionText { get; set; }
		[JsonPropertyName("azonosito")]
		public long? id { get; set; }
		[JsonPropertyName("idopont")]
		public string? recordDateAsString { get; set; }
	}
}
