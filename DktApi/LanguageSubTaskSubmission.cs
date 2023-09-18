using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class LanguageSubTaskSubmission
	{
		[JsonPropertyName("ertekelesOsztalyzatId")]
		public long? evaluationMarkId { get; set; }
		[JsonPropertyName("ertekelesSzazalek")]
		public long? evaluationPercent { get; set; }
		[JsonPropertyName("ertekelesSzoveg")]
		public string? evaluationText { get; set; }
		[JsonPropertyName("id")]
		public long id { get; set; }
		[JsonPropertyName("ertekelveVagyElfogadva")]
		public bool isAccepted { get; set; }
		[JsonPropertyName("osztalyzattalErtekelt")]
		public bool isEvaluationByMark { get; set; }
		[JsonPropertyName("szazalekkalErtekelt")]
		public bool isEvaluationByPercentage { get; set; }
		[JsonPropertyName("szoveggelErtekelt")]
		public bool isEvaluationByText { get; set; }
		[JsonPropertyName("xeropanSzazalek")]
		public long? percent { get; set; }
		[JsonPropertyName("statusz")]
		public State? state { get; set; }
		[JsonPropertyName("xeropanMegoldasBekuldesiIdeje")]
		public string? submissionDateAsString { get; set; }
		[JsonPropertyName("feladatId")]
		public long taskId { get; set; }
		[JsonPropertyName("xeropanMegoldassalToltottIdoPerc")]
		public long? timeSpent { get; set; }
		public class State
		{
			[JsonPropertyName("nev")]
			public string? stateName { get; set; }
			[JsonPropertyName("id")]
			public long uid { get; set; }
		}
	}
}