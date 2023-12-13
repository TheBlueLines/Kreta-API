/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Status
	{
		[JsonPropertyName("buildNumber")]
		public string? buildNumber { get; set; }
		[JsonPropertyName("enabledFeatures")]
		public List<string>? enabledFeatures { get; set; }
		[JsonPropertyName("fileHandlers")]
		public Dictionary<string, FileHandler>? fileHandlers { get; set; }
		[JsonPropertyName("idpUrl")]
		public string? idpUrl { get; set; }
		[JsonPropertyName("trackingId")]
		public string? trackingId { get; set; }
		public class FileHandler
		{
			[JsonPropertyName("apiUrl")]
			public string? apiUrl { get; set; }
			[JsonPropertyName("features")]
			public List<string>? features { get; set; }
		}
	}
}
