using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Contact
	{
		[JsonPropertyName("Email")]
		public string? email { get; set; }
		[JsonPropertyName("Id")]
		public string? id { get; set; }
		[JsonPropertyName("IsEmailMegerositve")]
		public bool isEmailVerified { get; set; }
		[JsonPropertyName("Telefonszam")]
		public string? phoneNumber { get; set; }
	}
}
