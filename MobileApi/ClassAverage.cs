using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class ClassAverage
	{
		[JsonPropertyName("TanuloAtlag")]
		public decimal average { get; set; }
		[JsonPropertyName("OsztalyCsoportAtlag")]
		public decimal classAverageNumber { get; set; }
		[JsonPropertyName("OsztalyCsoportAtlagtolValoElteres")]
		public decimal differenceFromClassAverage { get; set; }
		[JsonPropertyName("Tantargy")]
		public SubjectDescriptor? subject { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
	}
}
