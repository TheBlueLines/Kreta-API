using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class File
	{
		[JsonPropertyName("azonosito")]
		public int? id { get; set; }
		[JsonPropertyName("ideiglenesFajlAzonosito")]
		public string? temporaryFileId { get; set; }
	}
}