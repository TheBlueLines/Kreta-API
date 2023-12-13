/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Homework
	{
		[JsonPropertyName("TantargyNeve")]
		public string? subjectName { get; set; }
		[JsonPropertyName("Csatolmanyok")]
		public List<Attachment>? attachmentList { get; set; }
		[JsonPropertyName("RogzitesIdopontja")]
		public string? createDateAsString { get; set; }
		[JsonPropertyName("HataridoDatuma")]
		public string? deadlineDateAsString { get; set; }
		[JsonPropertyName("OsztalyCsoport")]
		public UidStructure? group { get; set; }
		[JsonPropertyName("IsCsatolasEngedelyezes")]
		public bool? isAllowToAttachFile { get; set; }
		[JsonPropertyName("IsMegoldva")]
		public bool? isDone { get; set; }
		[JsonPropertyName("IsTanuloHaziFeladatEnabled")]
		public bool? isStudentHomeworkEnabled { get; set; }
		[JsonPropertyName("IsTanarRogzitette")]
		public bool? isTeacherRecorded { get; set; }
		[JsonPropertyName("FeladasDatuma")]
		public string? recordDateAsString { get; set; }
		[JsonPropertyName("RogzitoTanarNeve")]
		public string? recorderTeacherName { get; set; }
		[JsonPropertyName("Tantargy")]
		public SubjectDescriptor? subject { get; set; }
		[JsonPropertyName("IsBeadhato")]
		public bool? submitable { get; set; }
		[JsonPropertyName("Szoveg")]
		public string? text { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
		public class Attachment
		{
			[JsonPropertyName("Nev")]
			public string? name { get; set; }
			[JsonPropertyName("Tipus")]
			public string? type { get; set; }
			[JsonPropertyName("Uid")]
			public string? uid { get; set; }
		}
	}
}
