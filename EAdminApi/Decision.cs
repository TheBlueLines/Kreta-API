using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Decision
	{
		[JsonPropertyName("dontesSzovege")]
		public string? adjudication { get; set; }
		[JsonPropertyName("hatarozatKotelezoDokumentumLista")]
		public List<ApplicationMandatoryDocument>? applicationMandatoryDocuments { get; set; }
		[JsonPropertyName("csatolmanyok")]
		public List<Attachment>? attachments { get; set; }
		[JsonPropertyName("hatarozatDatum")]
		public string? decisionDateAsString { get; set; }
		[JsonPropertyName("iktatottHatarozat")]
		public FiledDecision? filedDecision { get; set; }
		[JsonPropertyName("azonosito")]
		public string? id { get; set; }
		[JsonPropertyName("dontes")]
		public Judgement? judgement { get; set; }
		[JsonPropertyName("indoklas")]
		public string? justification { get; set; }
		[JsonPropertyName("isDigitalisanKikuldendo")]
		public bool needToBeSendDigitally { get; set; }
		[JsonPropertyName("postazasiStatusz")]
		public PostState? postState { get; set; }
		[JsonPropertyName("igazoltTavolletVegeDatum")]
		public string? requestedAbsenceEndAsString { get; set; }
		[JsonPropertyName("igazoltTavolletKezdeteDatum")]
		public string? requestedAbsenceStartAsString { get; set; }
		[JsonPropertyName("alairoKretaAzonosito")]
		public int signerId { get; set; }
	}
}
