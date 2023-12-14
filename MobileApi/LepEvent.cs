using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class LepEvent
	{
		[JsonPropertyName("Helyszin")]
		public string? address { get; set; }
		[JsonPropertyName("Datum")]
		public string? creationDateAsString { get; set; }
		[JsonPropertyName("EloadasVege")]
		public string? eventEndTimeAsString { get; set; }
		[JsonPropertyName("EloadasKezdete")]
		public string? eventStartTimeAsString { get; set; }
		[JsonPropertyName("EloadasNev")]
		public string? eventTitle { get; set; }
		[JsonPropertyName("GondviseloElfogadas")]
		public bool hasGuardianPermission { get; set; }
		[JsonPropertyName("Megjelent")]
		public bool hasStudentAppeared { get; set; }
		[JsonPropertyName("SzervezetNev")]
		public string? organizationName { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
	}
}
