/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Authentication
	{
		[JsonPropertyName("access_token")]
		public string? accessToken { get; set; }
		[JsonPropertyName("expires_in")]
		public int? expiresIn { get; set; }
		[JsonPropertyName("id_token")]
		public string? idToken { get; set; }
		[JsonPropertyName("refresh_token")]
		public string? refreshToken { get; set; }
		[JsonPropertyName("token_type")]
		public string? tokenType { get; set; }
	}
}
