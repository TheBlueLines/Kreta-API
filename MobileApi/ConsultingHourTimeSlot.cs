/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class ConsultingHourTimeSlot
	{
		[JsonPropertyName("VegIdopont")]
		public string? endTimeAsString { get; set; }
		[JsonPropertyName("IsJelentkeztem")]
		public bool? isReservedByMe { get; set; }
		[JsonPropertyName("KezdoIdopont")]
		public string? startTimeAsString { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
	}
}
