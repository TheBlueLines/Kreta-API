using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class ConsultingHourList
	{
		[JsonPropertyName("Fogadoorak")]
		public List<ConsultingHour>? consultingHours { get; set; }
		[JsonPropertyName("Tanar")]
		public UidNameStructure? teacherDescriptor { get; set; }
	}
}
