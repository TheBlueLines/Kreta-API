using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class ReadMessageRequest
	{
		[JsonPropertyName("postaladaElemAzonositoLista")]
		public long[]? mailBoxItemId { get; set; }
		[JsonPropertyName("isOlvasott")]
		public bool readByUser { get; set; }
	}
}
