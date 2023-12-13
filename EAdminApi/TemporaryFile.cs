/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class TemporaryFile
	{
		[JsonPropertyName("fajlAzonosito")]
		public string? fileId { get; set; }
		[JsonPropertyName("fajlMeretByteLength")]
		public long? fileLength { get; set; }
		[JsonPropertyName("utvonal")]
		public string? path { get; set; }
	}
}
