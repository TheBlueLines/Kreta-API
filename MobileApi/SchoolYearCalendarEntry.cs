/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class SchoolYearCalendarEntry
	{
		[JsonPropertyName("Datum")]
		public string? dateAsString { get; set; }
		[JsonPropertyName("Naptipus")]
		public ValueDescriptor? dayType { get; set; }
		[JsonPropertyName("OsztalyCsoport")]
		public UidStructure? group { get; set; }
		[JsonPropertyName("ElteroOrarendSzerintiTanitasiNap")]
		public ValueDescriptor? irregularDay { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
		[JsonPropertyName("OrarendiNapHetirendje")]
		public ValueDescriptor? weekTypeSchedule { get; set; }
	}
}
