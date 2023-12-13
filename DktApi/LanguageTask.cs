/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:32
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class LanguageTask
	{
		[JsonPropertyName("rogzitesIdopontja")]
		public string? creationTimeAsString { get; set; }
		[JsonPropertyName("beadasiHatarido")]
		public string? deadlineAsString { get; set; }
		[JsonPropertyName("groupId")]
		public string? groupId { get; set; }
		[JsonPropertyName("id")]
		public long? id { get; set; }
		[JsonPropertyName("alfeladatok")]
		public List<LanguageSubTask>? subTaskList { get; set; }
		[JsonPropertyName("szoveg")]
		public string? text { get; set; }
		[JsonPropertyName("cim")]
		public string? title { get; set; }
	}
}
