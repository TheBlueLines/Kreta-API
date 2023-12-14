using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class AnnouncedTest
	{
		[JsonPropertyName("TantargyNeve")]
		public string? subjectName { get; set; }
		[JsonPropertyName("BejelentesDatuma")]
		public string? announcedAtAsString { get; set; }
		[JsonPropertyName("OrarendiOraOraszama")]
		public int classScheduleNumber { get; set; }
		[JsonPropertyName("Datum")]
		public string? dateAsString { get; set; }
		[JsonPropertyName("OsztalyCsoport")]
		public UidStructure? group { get; set; }
		[JsonPropertyName("Modja")]
		public ValueDescriptor? mode { get; set; }
		[JsonPropertyName("Tantargy")]
		public SubjectDescriptor? subject { get; set; }
		[JsonPropertyName("RogzitoTanarNeve")]
		public string? teacher { get; set; }
		[JsonPropertyName("Temaja")]
		public string? theme { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
	}
}
