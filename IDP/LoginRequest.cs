using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class LoginRequest
	{
		public string? id { get; set; }
		public string? password { get; set; }
		public string? userName { get; set; }
	}
}
