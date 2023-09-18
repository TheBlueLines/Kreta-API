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
		public int bankAccountOwnerType { get; set; }
		[JsonPropertyName("SzamlavezetoBank")]
		public string? bankName { get; set; }
	}
}