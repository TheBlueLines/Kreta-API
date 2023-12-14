using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class ClassworkSolutionAttachmentPost
	{
		[JsonPropertyName("fajlId")]
		public string? fileId { get; set; }
		[JsonPropertyName("teljesFajlNev")]
		public string? fileName { get; set; }
		[JsonPropertyName("meretInBytes")]
		public long sizeInBytes { get; set; }
	}
}
