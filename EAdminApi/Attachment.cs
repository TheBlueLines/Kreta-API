using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Attachment
	{
		[JsonPropertyName("fajlNev")]
		public string? fileName { get; set; }
		[JsonPropertyName("azonosito")]
		public string? id { get; set; }
		[JsonPropertyName("fajl")]
		public TemporaryId? temporaryId { get; set; }
		public class TemporaryId
		{
			[JsonPropertyName("fileHandler")]
			public string? fileHandler { get; set; }
			[JsonPropertyName("azonosito")]
			public string? id { get; set; }
			[JsonPropertyName("utvonal")]
			public string? path { get; set; }
			[JsonPropertyName("ideiglenesFajlAzonosito")]
			public string? temporaryServerUid { get; set; }
		}
	}
}
