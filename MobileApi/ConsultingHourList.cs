/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

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
