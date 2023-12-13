/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class ToDoItem
	{
		[JsonPropertyName("megnevezes")]
		public string? appellation { get; set; }
		[JsonPropertyName("dokumentumSablonAzonosito")]
		public int? documentTemplateId { get; set; }
		[JsonPropertyName("vegrehajtoKretaAzonosito")]
		public int? executiveId { get; set; }
		[JsonPropertyName("segitseg")]
		public string? help { get; set; }
		[JsonPropertyName("segitsegUrl")]
		public string? helpUrl { get; set; }
		[JsonPropertyName("azonosito")]
		public int? id { get; set; }
		[JsonPropertyName("isAutomatikus")]
		public bool? isAutomatic { get; set; }
		[JsonPropertyName("isElektronizalt")]
		public bool? isOnline { get; set; }
		[JsonPropertyName("isKesz")]
		public bool? isReady { get; set; }
		[JsonPropertyName("isRendszerKesz")]
		public bool? isSystemReady { get; set; }
		[JsonPropertyName("cimke")]
		public string? label { get; set; }
		[JsonPropertyName("sorrend")]
		public string? sequence { get; set; }
		[JsonPropertyName("rendszerKeszSzoveg")]
		public string? systemReadyText { get; set; }
		[JsonPropertyName("teendoKotelezoDokumentum")]
		public ToDoMandatoryDocumentsList? toDoMandatoryDocumentsList { get; set; }
	}
}
