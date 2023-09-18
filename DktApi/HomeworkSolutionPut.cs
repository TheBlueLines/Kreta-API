using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class HomeworkSolutionPut
	{
		[JsonPropertyName("szoveg")]
		public string? text { get; set; }
	}
}