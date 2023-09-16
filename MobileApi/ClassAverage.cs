using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class ClassAverage
	{
		[JsonPropertyName("TanuloAtlag")]
		public double? average {  get; set; }
		[JsonPropertyName("OsztalyCsoportAtlag")]
		public double? classAverageNumber {  get; set; }
		[JsonPropertyName("OsztalyCsoportAtlagtolValoElteres")]
		public double? differenceFromClassAverage {  get; set; }
		[JsonPropertyName("Tantargy")]
		public SubjectDescriptor? subject {  get; set; }
		[JsonPropertyName("Uid")]
		public string? uid {  get; set; }
	}
}