using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class TimeTableWeek
	{
		[JsonPropertyName("VegNapDatuma")]
		public string? endDateAsString { get; set; }
		[JsonPropertyName("HetSorszama")]
		public int numberOfWeek { get; set; }
		[JsonPropertyName("KezdoNapDatuma")]
		public string? startDateAsString { get; set; }
		[JsonPropertyName("Tipus")]
		public ValueDescriptor? type { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
	}
}
