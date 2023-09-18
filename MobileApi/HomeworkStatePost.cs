using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class HomeworkStatePost
	{
		[JsonPropertyName("IsMegoldva")]
		public bool isDone { get; set; }
		[JsonPropertyName("TanarHaziFeladatUid")]
		public string? teacherHomeworkUid { get; set; }
	}
}