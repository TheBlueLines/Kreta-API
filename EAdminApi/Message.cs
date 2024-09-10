using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Message
	{
		[JsonPropertyName("cimzettLista")]
		public List<Addressee>? addressList { get; set; }
		[JsonPropertyName("isCimzettekElrejtve")]
		public bool addressesHidden { get; set; }
		[JsonPropertyName("csatolmanyok")]
		public List<Attachment>? attachmentList { get; set; }
		[JsonPropertyName("azonosito")]
		public long messageId { get; set; }
		[JsonPropertyName("feladoNev")]
		public string? messageSenderName { get; set; }
		[JsonPropertyName("feladoTitulus")]
		public string? messageSenderTitle { get; set; }
		[JsonPropertyName("kuldesDatum")]
		public string? messageSentDateAsString { get; set; }
		[JsonPropertyName("targy")]
		public string? messageSubject { get; set; }
		[JsonPropertyName("szoveg")]
		public string? messageText { get; set; }
		[JsonPropertyName("elozoUzenetAzonosito")]
		public long previousMessageId { get; set; }
	}
}
