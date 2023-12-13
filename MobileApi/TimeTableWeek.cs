/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class TimeTableWeek
	{
		[JsonPropertyName("VegNapDatuma")]
		public string? endDateAsString { get; set; }
		[JsonPropertyName("HetSorszama")]
		public int? numberOfWeek { get; set; }
		[JsonPropertyName("KezdoNapDatuma")]
		public string? startDateAsString { get; set; }
		[JsonPropertyName("Tipus")]
		public ValueDescriptor? type { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
	}
}
