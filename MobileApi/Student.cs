/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Student
	{
		[JsonPropertyName("Cimek")]
		public List<string>? addressDataList { get; set; }
		[JsonPropertyName("Bankszamla")]
		public BankAccount? bankAccount { get; set; }
		[JsonPropertyName("SzuletesiNap")]
		public int? dayOfBirth { get; set; }
		[JsonPropertyName("EmailCim")]
		public string? emailAddress { get; set; }
		[JsonPropertyName("Gondviselok")]
		public List<Guardian>? guardianList { get; set; }
		[JsonPropertyName("IntezmenyAzonosito")]
		public string? instituteCode { get; set; }
		[JsonPropertyName("IntezmenyNev")]
		public string? instituteName { get; set; }
		[JsonPropertyName("Intezmeny")]
		public Institution? institution { get; set; }
		[JsonPropertyName("SzuletesiHonap")]
		public int? monthOfBirth { get; set; }
		[JsonPropertyName("AnyjaNeve")]
		public string? mothersName { get; set; }
		[JsonPropertyName("Nev")]
		public string? name { get; set; }
		[JsonPropertyName("SzuletesiNev")]
		public string? nameOfBirth { get; set; }
		[JsonPropertyName("Telefonszam")]
		public string? phoneNumber { get; set; }
		[JsonPropertyName("SzuletesiHely")]
		public string? placeOfBirth { get; set; }
		[JsonPropertyName("TanevUid")]
		public long? schoolYearUID { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
		[JsonPropertyName("SzuletesiEv")]
		public int? yearOfBirth { get; set; }
		public class BankAccount
		{
			[JsonPropertyName("BankszamlaSzam")]
			public string? accountNumber { get; set; }
			[JsonPropertyName("IsReadOnly")]
			public Boolean? isReadOnly { get; set; }
			[JsonPropertyName("BankszamlaTulajdonosNeve")]
			public string? ownerName { get; set; }
			[JsonPropertyName("BankszamlaTulajdonosTipusId")]
			public int? ownerType { get; set; }
		}
	}
}
