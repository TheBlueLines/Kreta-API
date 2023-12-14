using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class AccessControlSystemItem
	{
		[JsonPropertyName("megjegyzes")]
		public string? commentText { get; set; }
		[JsonPropertyName("irany")]
		public string? directionText { get; set; }
		[JsonPropertyName("azonosito")]
		public long id { get; set; }
		[JsonPropertyName("idopont")]
		public string? recordDateAsString { get; set; }
	}
}
