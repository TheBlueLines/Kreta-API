/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Omission
	{
		[JsonPropertyName("KeszitesDatuma")]
		public string? creatingTimeAsString { get; set; }
		[JsonPropertyName("Datum")]
		public string? dateAsString { get; set; }
		[JsonPropertyName("KesesPercben")]
		public int? delayTimeMinutes { get; set; }
		[JsonPropertyName("OsztalyCsoport")]
		public UidStructure? group { get; set; }
		[JsonPropertyName("IgazolasAllapota")]
		public string? justificationState { get; set; }
		[JsonPropertyName("IgazolasTipusa")]
		public ValueDescriptor? justificationType { get; set; }
		[JsonPropertyName("Ora")]
		public Lesson? lesson { get; set; }
		[JsonPropertyName("Mod")]
		public ValueDescriptor? mode { get; set; }
		[JsonPropertyName("Tantargy")]
		public SubjectDescriptor? subject { get; set; }
		[JsonPropertyName("RogzitoTanarNeve")]
		public string? teacher { get; set; }
		[JsonPropertyName("Tipus")]
		public ValueDescriptor? type { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
		public class Lesson
		{
			[JsonPropertyName("VegDatum")]
			public string? endTimeAsString { get; set; }
			[JsonPropertyName("Oraszam")]
			public int? scheduleNumber { get; set; }
			[JsonPropertyName("KezdoDatum")]
			public string? startTimeAsString { get; set; }
		}
	}
}
