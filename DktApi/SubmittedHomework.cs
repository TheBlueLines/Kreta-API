/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:32
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class SubmittedHomework
	{
		[JsonPropertyName("letrehozva")]
		public string? creationTimeAsString { get; set; }
		[JsonPropertyName("feladatId")]
		public int? homeworkId { get; set; }
		[JsonPropertyName("id")]
		public long? id { get; set; }
		[JsonPropertyName("utoljaraModositva")]
		public string? lastModifiedAsString { get; set; }
		[JsonPropertyName("szoveg")]
		public string? solutionText { get; set; }
		[JsonPropertyName("statuszId")]
		public int? statusId { get; set; }
		[JsonPropertyName("statuszNev")]
		public string? statusName { get; set; }
		[JsonPropertyName("tanuloGuid")]
		public string? studentGuid { get; set; }
		[JsonPropertyName("tanuloId")]
		public int? studentId { get; set; }
		[JsonPropertyName("tanuloNev")]
		public string? studentName { get; set; }
		[JsonPropertyName("egyediId")]
		public string? uniqueId { get; set; }
	}
}
