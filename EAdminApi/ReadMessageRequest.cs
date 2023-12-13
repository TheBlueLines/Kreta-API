/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class ReadMessageRequest
	{
		[JsonPropertyName("postaladaElemAzonositoLista")]
		public long[]? mailBoxItemId { get; set; }
		[JsonPropertyName("isOlvasott")]
		public bool? readByUser { get; set; }
	}
}
