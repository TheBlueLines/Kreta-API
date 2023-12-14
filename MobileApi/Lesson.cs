using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Lesson
	{
		[JsonPropertyName("BejelentettSzamonkeresUid")]
		public string? announcedTestUid { get; set; }
		[JsonPropertyName("Csatolmanyok")]
		public List<Attachment>? attachments { get; set; }
		[JsonPropertyName("OsztalyCsoport")]
		public UidNameStructure? classGroup { get; set; }
		[JsonPropertyName("Oraszam")]
		public int classScheduleNumber { get; set; }
		[JsonPropertyName("TeremNeve")]
		public string? classroom { get; set; }
		[JsonPropertyName("FeladatGroupUid")]
		public string? classworkGroupId { get; set; }
		[JsonPropertyName("DigitalisEszkozTipus")]
		public string? digitalInstrumentType { get; set; }
		[JsonPropertyName("DigitalisPlatformTipus")]
		public string? digitalPlatformType { get; set; }
		[JsonPropertyName("VegIdopont")]
		public string? endTimeAsString { get; set; }
		[JsonPropertyName("HaziFeladatUid")]
		public string? homeWorkUid { get; set; }
		[JsonPropertyName("IsTanuloHaziFeladatEnabled")]
		public bool homeworkEditedByStudentEnabled { get; set; }
		[JsonPropertyName("IsDigitalisOra")]
		public bool isDigitalLesson { get; set; }
		[JsonPropertyName("NyelviFeladatGroupUid")]
		public string? languageTaskGroupId { get; set; }
		[JsonPropertyName("OraEvesSorszama")]
		public int lessonNumber { get; set; }
		[JsonPropertyName("Nev")]
		public string? name { get; set; }
		[JsonPropertyName("TanuloJelenlet")]
		public ValueDescriptor? presence { get; set; }
		[JsonPropertyName("KezdetIdopont")]
		public string? startTimeAsString { get; set; }
		[JsonPropertyName("Allapot")]
		public ValueDescriptor? state { get; set; }
		[JsonPropertyName("Tantargy")]
		public SubjectDescriptor? subject { get; set; }
		[JsonPropertyName("HelyettesTanarNeve")]
		public string? supplyTeacher { get; set; }
		[JsonPropertyName("DigitalisTamogatoEszkozTipusList")]
		public List<string>? supportedDigitalInstrumentTypes { get; set; }
		[JsonPropertyName("TanarNeve")]
		public string? teacher { get; set; }
		[JsonPropertyName("Tema")]
		public string? topic { get; set; }
		[JsonPropertyName("Tipus")]
		public ValueDescriptor? type { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
		public class Attachment
		{
			[JsonPropertyName("Nev")]
			public string? name { get; set; }
			[JsonPropertyName("Uid")]
			public string? uid { get; set; }
		}
	}
}
