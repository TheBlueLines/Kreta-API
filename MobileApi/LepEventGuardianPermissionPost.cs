using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class LepEventGuardianPermissionPost
	{
		[JsonPropertyName("EloadasId")]
		public int eventId { get; set; }
		[JsonPropertyName("Dontes")]
		public bool? isPermitted { get; set; }
	}
}