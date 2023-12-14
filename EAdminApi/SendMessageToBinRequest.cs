using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class SendMessageToBinRequest
	{
		[JsonPropertyName("isKuka")]
		public bool deleted { get; set; }
		[JsonPropertyName("postaladaElemAzonositoLista")]
		public long[]? mailBoxItemId { get; set; }
	}
}
