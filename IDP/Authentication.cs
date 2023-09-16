using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Authentication
	{
		[JsonPropertyName("access_token")]
		public string? accessToken { get; set; }
		[JsonPropertyName("expires_in")]
		public int expiresIn { get; set; }
		[JsonPropertyName("id_token")]
		public string? idToken { get; set; }
		[JsonPropertyName("refresh_token")]
		public string? refreshToken { get; set; }
		[JsonPropertyName("token_type")]
		public string? tokenType { get; set; }
	}
}