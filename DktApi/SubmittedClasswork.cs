/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:32
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class SubmittedClasswork
	{
		[JsonPropertyName("megjegyzes")]
		public string? comment { get; set; }
		[JsonPropertyName("elfogadottNemElfogadott")]
		public Boolean? evaluatedByAccepting { get; set; }
		[JsonPropertyName("osztalyzattalErtekelt")]
		public Boolean? evaluatedByMark { get; set; }
		[JsonPropertyName("szazalekkalErtekelt")]
		public Boolean? evaluatedByPercent { get; set; }
		[JsonPropertyName("pontszammalErtekelt")]
		public Boolean? evaluatedByScore { get; set; }
		[JsonPropertyName("szoveggelErtekelt")]
		public Boolean? evaluatedByText { get; set; }
		[JsonPropertyName("ertekelesOsztalyzatNev")]
		public string? evaluationMark { get; set; }
		[JsonPropertyName("ertekelesSzazalek")]
		public string? evaluationPercent { get; set; }
		[JsonPropertyName("pontszam")]
		public double? evaluationScore { get; set; }
		[JsonPropertyName("ertekelesSzoveg")]
		public string? evaluationText { get; set; }
		[JsonPropertyName("id")]
		public long? id { get; set; }
		[JsonPropertyName("ertekelveVagyElfogadva")]
		public Boolean? isEvaluatedOrAccepted { get; set; }
		[JsonPropertyName("szoveg")]
		public string? solutionText { get; set; }
		[JsonPropertyName("statuszId")]
		public int? statusId { get; set; }
		[JsonPropertyName("egyediId")]
		public string? uniqueId { get; set; }
	}
}
