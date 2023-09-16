using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class ConsultingHour
	{
		[JsonPropertyName("Terem")]
		public UidNameStructure? classroomDescriptor { get; set; }
		[JsonPropertyName("Idopontok")]
		public List<ConsultingHourTimeSlot>? consultingHourTimeSlots { get; set; }
		[JsonPropertyName("JelentkezesHatarido")]
		public string? deadlineAsString { get; set; }
		[JsonPropertyName("VegIdopont")]
		public string? endTimeAsString { get; set; }
		[JsonPropertyName("IsJelentkezesFeatureEnabled")]
		public bool isReservationEnabled { get; set; }
		[JsonPropertyName("KezdoIdopont")]
		public string? startTimeAsString { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
	}
}