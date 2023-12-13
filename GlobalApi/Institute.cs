/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Institute
	{
		[JsonPropertyName("telepules")]
		public string? city { get; set; }
		[JsonPropertyName("kornyezetNev")]
		public string? environmentName { get; set; }
		[JsonPropertyName("id")]
		public string? id { get; set; }
		[JsonPropertyName("azonosito")]
		public string? instituteCode { get; set; }
		[JsonPropertyName("nev")]
		public string? name { get; set; }
		[JsonPropertyName("kretaLink")]
		public string? url { get; set; }
	}
}
