/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class RectificationPost
	{
		[JsonPropertyName("azonosito")]
		public string? caseId { get; set; }
		[JsonPropertyName("tipus")]
		public Type? caseType { get; set; }
		[JsonPropertyName("tipusKod")]
		public string? caseTypeCode { get; set; }
		[JsonPropertyName("csatolmanyok")]
		public List<OtherThingsToDoAttachments>? optionalAttachments { get; set; }
		[JsonPropertyName("statusz")]
		public State? state { get; set; }
	}
}
