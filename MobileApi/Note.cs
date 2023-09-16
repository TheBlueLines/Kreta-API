using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Note
	{
		[JsonPropertyName("Tartalom")]
		public string? content {  get; set; }
		[JsonPropertyName("KeszitesDatuma")]
		public string? creatingTimeAsString {  get; set; }
		[JsonPropertyName("Datum")]
		public string? dateAsString {  get; set; }
		[JsonPropertyName("OsztalyCsoport")]
		public UidStructure? group {  get; set; }
		[JsonPropertyName("LattamozasDatuma")]
		public string? seenByTutelaryAsString {  get; set; }
		[JsonPropertyName("KeszitoTanarNeve")]
		public string? teacher {  get; set; }
		[JsonPropertyName("Cim")]
		public string? title {  get; set; }
		[JsonPropertyName("Tipus")]
		public ValueDescriptor? type {  get; set; }
		[JsonPropertyName("Uid")]
		public string? uid {  get; set; }
	}
}