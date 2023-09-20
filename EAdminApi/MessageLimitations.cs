using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class MessageLimitations
	{
		[JsonPropertyName("isCsakEgyCimzettLehet")]
		public bool isMessageOnlyOneAddresseeLimitation { get; set; }
		[JsonPropertyName("isKuldhetoUzenetekSzamaKorlatozvaVan")]
		public bool isSendableMessagesLimitation { get; set; }
		[JsonPropertyName("kuldhetoUzenetekSzamaMegMa")]
		public int sendableMessagesTodayCount { get; set; }
	}
}