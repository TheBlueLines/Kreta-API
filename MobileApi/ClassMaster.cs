/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class ClassMaster
	{
		[JsonPropertyName("Osztalyai")]
		public List<SchoolClass>? listOfClass { get; set; }
		[JsonPropertyName("Tanar")]
		public Teacher? teacher { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
		public class Email
		{
			[JsonPropertyName("Email")]
			public string? email { get; set; }
			[JsonPropertyName("Uid")]
			public string? uid { get; set; }
		}
		public class Employee
		{
			[JsonPropertyName("Emailek")]
			public List<Email>? emailList { get; set; }
			[JsonPropertyName("Nev")]
			public string? name { get; set; }
			[JsonPropertyName("Telefonok")]
			public List<Phone>? phoneList { get; set; }
			[JsonPropertyName("Uid")]
			public string? uid { get; set; }
		}
		public class Phone
		{
			[JsonPropertyName("Telefonszam")]
			public string? phone { get; set; }
			[JsonPropertyName("Uid")]
			public string? uid { get; set; }
		}
		public class Teacher
		{
			[JsonPropertyName("Alkalmazott")]
			public Employee? employee { get; set; }
			[JsonPropertyName("Uid")]
			public string? uid { get; set; }
		}
	}
}
