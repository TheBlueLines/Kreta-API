/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class TmgiCasePost
	{
		[JsonPropertyName("igazolasTipus")]
		public Type? caseType { get; set; }
		[JsonPropertyName("tanuloOsztaly")]
		public string? educationClassName { get; set; }
		[JsonPropertyName("tanuloOktatasiAzonosito")]
		public string? educationId { get; set; }
		[JsonPropertyName("igazoltTavolletVegeDatum")]
		public string? endDate { get; set; }
		[JsonPropertyName("kerelemKotelezoDokumentumLista")]
		public List<ApplicationMandatoryDocument>? mandatoryAttachments { get; set; }
		[JsonPropertyName("csatolmanyok")]
		public List<OtherThingsToDoAttachments>? optionalAttachments { get; set; }
		[JsonPropertyName("indoklas")]
		public string? reason { get; set; }
		[JsonPropertyName("igazoltTavolletKezdeteDatum")]
		public string? startDate { get; set; }
		[JsonPropertyName("tanuloCsaladiNev")]
		public string? studentFirstName { get; set; }
		[JsonPropertyName("tanuloKeresztNev")]
		public string? studentLastName { get; set; }
		[JsonPropertyName("tipus")]
		public Type? type { get; set; }
		[JsonPropertyName("tipusKod")]
		public string? typeCode { get; set; }
	}
}
