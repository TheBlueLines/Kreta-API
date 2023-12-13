/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

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
		public int? sortIndex { get; set; }
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
			public float? average { get; set; }
			public DateTime? date { get; set; }
			[JsonPropertyName("Datum")]
			public string? dateAsString { get; set; }
		}
	}
}
