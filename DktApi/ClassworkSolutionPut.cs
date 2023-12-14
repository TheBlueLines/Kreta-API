using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class ClassworkSolutionPut
	{
		[JsonPropertyName("szoveg")]
		public string? text { get; set; }
	}
}
