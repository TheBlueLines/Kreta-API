using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class LanguageTaskSubmission
	{
		[JsonPropertyName("feladatId")]
		public string? assignmentId { get; set; }
		[JsonPropertyName("ertekelesOsztalyzatId")]
		public long? evaluationMarkId { get; set; }
		[JsonPropertyName("ertekelesSzazalek")]
		public long? evaluationPercent { get; set; }
		[JsonPropertyName("ertekelesSzoveg")]
		public string? evaluationText { get; set; }
		[JsonPropertyName("feladatGroupId")]
		public string? groupId { get; set; }
		[JsonPropertyName("id")]
		public long id { get; set; }
		[JsonPropertyName("elfogadottNemElfogadott")]
		public bool isAccepted { get; set; }
		[JsonPropertyName("osztalyzattalErtekelt")]
		public bool isEvaluationByMark { get; set; }
		[JsonPropertyName("szazalekkalErtekelt")]
		public bool isEvaluationByPercentage { get; set; }
		[JsonPropertyName("szoveggelErtekelt")]
		public bool isEvaluationByText { get; set; }
		[JsonPropertyName("statusz")]
		public State? state { get; set; }
		[JsonPropertyName("alfeladatBeadasok")]
		public List<LanguageSubTaskSubmission>? subTaskSubmissionList { get; set; }
		public class State
		{
			[JsonPropertyName("nev")]
			public string? stateName { get; set; }
			[JsonPropertyName("id")]
			public long uid { get; set; }
		}
	}
}