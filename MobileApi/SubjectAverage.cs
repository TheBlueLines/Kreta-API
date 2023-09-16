using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class SubjectAverage
	{
		[JsonPropertyName("Atlag")]
		public decimal? averageNumber { get; set; }
		[JsonPropertyName("AtlagAlakulasaIdoFuggvenyeben")]
		public List<AverageWithTime>? averagesInTime { get; set; }
		[JsonPropertyName("SortIndex")]
		public int sortIndex { get; set; }
		[JsonPropertyName("Tantargy")]
		public SubjectDescriptor? subject { get; set; }
		[JsonPropertyName("SulyozottOsztalyzatOsszege")]
		public float? sumOfWeightedEvaluations { get; set; }
		[JsonPropertyName("SulyozottOsztalyzatSzama")]
		public float? sumOfWeights { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
		public class AverageWithTime
		{
			[JsonPropertyName("Atlag")]
			public float average { get; set; }
			[JsonPropertyName("Datum")]
			public string? dateAsString { get; set; }
		}
	}
}