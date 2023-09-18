using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class SubmittedClasswork
	{
		[JsonPropertyName("megjegyzes")]
		public string? comment { get; set; }
		[JsonPropertyName("elfogadottNemElfogadott")]
		public bool? evaluatedByAccepting { get; set; }
		[JsonPropertyName("osztalyzattalErtekelt")]
		public bool? evaluatedByMark { get; set; }
		[JsonPropertyName("szazalekkalErtekelt")]
		public bool? evaluatedByPercent { get; set; }
		[JsonPropertyName("pontszammalErtekelt")]
		public bool? evaluatedByScore { get; set; }
		[JsonPropertyName("szoveggelErtekelt")]
		public bool? evaluatedByText { get; set; }
		[JsonPropertyName("ertekelesOsztalyzatNev")]
		public string? evaluationMark { get; set; }
		[JsonPropertyName("ertekelesSzazalek")]
		public string? evaluationPercent { get; set; }
		[JsonPropertyName("pontszam")]
		public double? evaluationScore { get; set; }
		[JsonPropertyName("ertekelesSzoveg")]
		public string? evaluationText { get; set; }
		[JsonPropertyName("id")]
		public long id { get; set; }
		[JsonPropertyName("ertekelveVagyElfogadva")]
		public bool? isEvaluatedOrAccepted { get; set; }
		[JsonPropertyName("szoveg")]
		public string? solutionText { get; set; }
		[JsonPropertyName("statuszId")]
		public int statusId { get; set; }
		[JsonPropertyName("egyediId")]
		public string? uid { get; set; }
	}
}