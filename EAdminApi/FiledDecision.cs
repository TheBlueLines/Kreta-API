using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class FiledDecision
	{
		[JsonPropertyName("azonosito")]
		public int id { get; set; }
	}
}
