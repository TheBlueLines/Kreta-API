using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class SubjectDescriptor
	{
		[JsonPropertyName("Nev")]
		public string? name { get; set; }
		[JsonPropertyName("Kategoria")]
		public ValueDescriptor? subjectCategory { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
	}
}