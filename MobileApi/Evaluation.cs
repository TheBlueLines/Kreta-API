/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Evaluation
	{
		[JsonPropertyName("KeszitesDatuma")]
		public string? creatingTimeAsString { get; set; }
		[JsonPropertyName("Jelleg")]
		public string? form { get; set; }
		[JsonPropertyName("ErtekFajta")]
		public ValueDescriptor? formType { get; set; }
		[JsonPropertyName("OsztalyCsoport")]
		public UidStructure? group { get; set; }
		[JsonPropertyName("Mod")]
		public ValueDescriptor? mode { get; set; }
		[JsonPropertyName("SzamErtek")]
		public int? numberValue { get; set; }
		[JsonPropertyName("RogzitesDatuma")]
		public string? recordDateAsString { get; set; }
		[JsonPropertyName("LattamozasDatuma")]
		public string? seenByTutelaryAsString { get; set; }
		[JsonPropertyName("SzovegesErtekelesRovidNev")]
		public string? shortValue { get; set; }
		[JsonPropertyName("SortIndex")]
		public int? sortIndex { get; set; }
		[JsonPropertyName("Tantargy")]
		public SubjectDescriptor? subject { get; set; }
		[JsonPropertyName("ErtekeloTanarNeve")]
		public string? teacher { get; set; }
		[JsonPropertyName("Tema")]
		public string? theme { get; set; }
		[JsonPropertyName("Tipus")]
		public ValueDescriptor? type { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
		[JsonPropertyName("SzovegesErtek")]
		public string? value { get; set; }
		[JsonPropertyName("SulySzazalekErteke")]
		public string? weight { get; set; }
	}
}
