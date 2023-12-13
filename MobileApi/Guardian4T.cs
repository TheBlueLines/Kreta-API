/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Guardian4T
	{
		[JsonPropertyName("SzuletesiDatum")]
		public string? dateOfBirthAsString { get; set; }
		[JsonPropertyName("Utonev")]
		public string? firstname { get; set; }
		[JsonPropertyName("SzuletesiUtonev")]
		public string? firstnameOfBirth { get; set; }
		[JsonPropertyName("AnyjaUtonev")]
		public string? mothersFirstname { get; set; }
		[JsonPropertyName("AnyjaVezeteknev")]
		public string? mothersSurname { get; set; }
		[JsonPropertyName("Elotag")]
		public string? namePrefix { get; set; }
		[JsonPropertyName("SzuletesiHely")]
		public string? placeOfBirth { get; set; }
		[JsonPropertyName("Vezeteknev")]
		public string? surname { get; set; }
		[JsonPropertyName("SzuletesiVezeteknev")]
		public string? surnameOfBirth { get; set; }
	}
}
