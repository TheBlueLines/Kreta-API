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
	}
}