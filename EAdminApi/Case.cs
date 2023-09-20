using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Case
	{
		[JsonPropertyName("ugyintezo")]
		public Administrator? administrator { get; set; }
		[JsonPropertyName("kerelmezo")]
		public Applicants? applicants { get; set; }
		[JsonPropertyName("kerelemKotelezoDokumentumLista")]
		public List<ApplicationMandatoryDocument>? applicationMandatoryDocument { get; set; }
		[JsonPropertyName("csatolmanyok")]
		public List<Attachment>? attachments { get; set; }
		[JsonPropertyName("hatarozatLista")]
		public List<Decision>? decisions { get; set; }
		[JsonPropertyName("ugyiratszam")]
		public string? documentNumber { get; set; }
		[JsonPropertyName("iktatottKerelem")]
		public FiledApplication? filedApplication { get; set; }
		[JsonPropertyName("elozmenyUgyiratszam")]
		public string? historyFileNumber { get; set; }
		[JsonPropertyName("azonosito")]
		public int id { get; set; }
		[JsonPropertyName("belsoHataridoDatum")]
		public string? internalDeadlineDateAsString { get; set; }
		[JsonPropertyName("belsoMegjegyzes")]
		public string? internalNote { get; set; }
		[JsonPropertyName("igazolasTipus")]
		public Type? justificationType { get; set; }
		[JsonPropertyName("utolsoModositasDatum")]
		public string? lastModificationDateAsString { get; set; }
		[JsonPropertyName("teendoEgyebCsatolmanyok")]
		public List<OtherThingsToDoAttachments>? otherThingsToDoAttachments { get; set; }
		[JsonPropertyName("postazasiStatusz")]
		public PostState? postState { get; set; }
		[JsonPropertyName("indoklas")]
		public string? reason { get; set; }
		[JsonPropertyName("iktatoszam")]
		public string? registrationNumber { get; set; }
		[JsonPropertyName("igazoltTavolletVegeDatum")]
		public string? requestedAbsenceEndAsString { get; set; }
		[JsonPropertyName("igazoltTavolletKezdeteDatum")]
		public string? requestedAbsenceStartAsString { get; set; }
		[JsonPropertyName("bekuldesDatum")]
		public string? sentDateAsString { get; set; }
		[JsonPropertyName("statusz")]
		public State? state { get; set; }
		[JsonPropertyName("tanuloOsztaly")]
		public string? studentClass { get; set; }
		[JsonPropertyName("tanuloOktatasiAzonosito")]
		public string? studentEducationId { get; set; }
		[JsonPropertyName("tanuloCsaladiNev")]
		public string? studentFamilyName { get; set; }
		[JsonPropertyName("tanuloKeresztNev")]
		public string? studentFirstName { get; set; }
		[JsonPropertyName("isDigitalisanBekuldve")]
		public bool? submittedDigitally { get; set; }
		[JsonPropertyName("teendoLista")]
		public List<ToDoItem>? toDoItem { get; set; }
		[JsonPropertyName("tipus")]
		public Type? type { get; set; }
		[JsonPropertyName("tipusKod")]
		public string? typeCode { get; set; }
	}
}