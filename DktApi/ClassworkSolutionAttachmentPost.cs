/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:32
*/

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
		public long? sizeInBytes { get; set; }
	}
}
