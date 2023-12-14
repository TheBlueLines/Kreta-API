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
