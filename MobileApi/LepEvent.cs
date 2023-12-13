/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class LepEvent
	{
		[JsonPropertyName("Helyszin")]
		public string? address { get; set; }
		[JsonPropertyName("Datum")]
		public string? creationDateAsString { get; set; }
		[JsonPropertyName("EloadasVege")]
		public string? eventEndTimeAsString { get; set; }
		[JsonPropertyName("EloadasKezdete")]
		public string? eventStartTimeAsString { get; set; }
		[JsonPropertyName("EloadasNev")]
		public string? eventTitle { get; set; }
		[JsonPropertyName("GondviseloElfogadas")]
		public Boolean? hasGuardianPermission { get; set; }
		[JsonPropertyName("Megjelent")]
		public bool? hasStudentAppeared { get; set; }
		[JsonPropertyName("SzervezetNev")]
		public string? organizationName { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
	}
}
