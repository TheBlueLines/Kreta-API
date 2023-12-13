/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class LepEventGuardianPermissionPost
	{
		[JsonPropertyName("EloadasId")]
		public int? eventId { get; set; }
		[JsonPropertyName("Dontes")]
		public Boolean? isPermitted { get; set; }
	}
}
