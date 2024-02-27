using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class TeszekRegistration
	{
		[JsonPropertyName("Id")]
		public string? id { get; set; }
		[JsonPropertyName("RegisztracioIdopontja")]
		public string? registrationDateAsString { get; set; }
	}
}
