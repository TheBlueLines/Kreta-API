/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:32
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Child
	{
		[JsonPropertyName("oktatasiAzonosito")]
		public long? educationId { get; set; }
		[JsonPropertyName("vezetekNev")]
		public string? firstName { get; set; }
		[JsonPropertyName("keresztNev")]
		public string? lastName { get; set; }
		[JsonPropertyName("osztaly")]
		public string? studentClass { get; set; }
	}
}
