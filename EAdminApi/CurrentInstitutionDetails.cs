/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:32
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class CurrentInstitutionDetails
	{
		[JsonPropertyName("penztarjelentesAzonositoElotag")]
		public string? cashReportIdPrefix { get; set; }
		[JsonPropertyName("tankeruletNeve")]
		public string? educationDistrictName { get; set; }
		[JsonPropertyName("azonosito")]
		public int? id { get; set; }
		[JsonPropertyName("intezmenyCim")]
		public string? institutionAddress { get; set; }
		[JsonPropertyName("kretaIntezmenyAzonosito")]
		public string? institutionId { get; set; }
		[JsonPropertyName("isAltalanos")]
		public Boolean? isBasicLevel { get; set; }
		[JsonPropertyName("IsUzenetKezelesElerheto")]
		public Boolean? isMessageHandlingAccessible { get; set; }
		[JsonPropertyName("isKozepfoku")]
		public Boolean? isMidLevel { get; set; }
		[JsonPropertyName("isSzeusz")]
		public Boolean? isSzeusz { get; set; }
		[JsonPropertyName("nev")]
		public string? name { get; set; }
		[JsonPropertyName("ertesitesiEmailCim")]
		public string? notificationEmailAddress { get; set; }
		[JsonPropertyName("omAzonosito")]
		public string? omId { get; set; }
	}
}
