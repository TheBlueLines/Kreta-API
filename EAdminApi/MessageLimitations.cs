/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class MessageLimitations
	{
		[JsonPropertyName("isCsakEgyCimzettLehet")]
		public bool? isMessageOnlyOneAddresseeLimitation { get; set; }
		[JsonPropertyName("isKuldhetoUzenetekSzamaKorlatozvaVan")]
		public bool? isSendableMessagesLimitation { get; set; }
		[JsonPropertyName("kuldhetoUzenetekSzamaMegMa")]
		public int? sendableMessagesTodayCount { get; set; }
	}
}
