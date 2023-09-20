using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Administrator
	{
		[JsonPropertyName("azonosito")]
		public int id { get; set; }
		[JsonPropertyName("nev")]
		public string? shortName { get; set; }
		[JsonPropertyName("titulus")]
		public string? title { get; set; }
		[JsonPropertyName("kretaFelhasznaloAzonosito")]
		public int userId { get; set; }
		[JsonPropertyName("felhasznaloNev")]
		public string? userName { get; set; }
	}
}