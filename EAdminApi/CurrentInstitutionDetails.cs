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
		public bool? isBasicLevel { get; set; }
		[JsonPropertyName("IsUzenetKezelesElerheto")]
		public bool? isMessageHandlingAccessible { get; set; }
		[JsonPropertyName("isKozepfoku")]
		public bool? isMidLevel { get; set; }
		[JsonPropertyName("isSzeusz")]
		public bool? isSzeusz { get; set; }
		[JsonPropertyName("nev")]
		public string? name { get; set; }
		[JsonPropertyName("ertesitesiEmailCim")]
		public string? notificationEmailAddress { get; set; }
		[JsonPropertyName("omAzonosito")]
		public string? omId { get; set; }
	}
}