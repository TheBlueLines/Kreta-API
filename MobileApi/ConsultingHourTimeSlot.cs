using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class ConsultingHourTimeSlot
	{
		[JsonPropertyName("VegIdopont")]
		public string? endTimeAsString { get; set; }
		[JsonPropertyName("IsJelentkeztem")]
		public bool isReservedByMe { get; set; }
		[JsonPropertyName("KezdoIdopont")]
		public string? startTimeAsString { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
	}
}