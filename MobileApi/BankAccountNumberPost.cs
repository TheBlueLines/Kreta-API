/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class BankAccountNumberPost
	{
		[JsonPropertyName("BankszamlaSzam")]
		public string? bankAccountNumber { get; set; }
		[JsonPropertyName("BankszamlaTulajdonosNeve")]
		public string? bankAccountOwnerName { get; set; }
		[JsonPropertyName("BankszamlaTulajdonosTipusId")]
		public int? bankAccountOwnerType { get; set; }
		[JsonPropertyName("SzamlavezetoBank")]
		public string? bankName { get; set; }
	}
}
