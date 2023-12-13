/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class ClassAverage
	{
		[JsonPropertyName("TanuloAtlag")]
		public decimal? average { get; set; }
		[JsonPropertyName("OsztalyCsoportAtlag")]
		public decimal? classAverageNumber { get; set; }
		[JsonPropertyName("OsztalyCsoportAtlagtolValoElteres")]
		public decimal? differenceFromClassAverage { get; set; }
		[JsonPropertyName("Tantargy")]
		public SubjectDescriptor? subject { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
	}
}
