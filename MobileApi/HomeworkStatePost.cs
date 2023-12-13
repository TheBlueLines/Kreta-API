/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class HomeworkStatePost
	{
		[JsonPropertyName("IsMegoldva")]
		public bool? isDone { get; set; }
		[JsonPropertyName("TanarHaziFeladatUid")]
		public string? teacherHomeworkUid { get; set; }
	}
}
