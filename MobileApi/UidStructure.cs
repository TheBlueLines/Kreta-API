using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class UidStructure
	{
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
	}
}
