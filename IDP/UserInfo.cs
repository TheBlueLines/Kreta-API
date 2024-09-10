using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class UserInfo
	{
		[JsonPropertyName("email_verified")]
		public bool emailVerified { get; set; }
	}
}
