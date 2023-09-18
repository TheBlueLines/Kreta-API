using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class KretaClass
	{
		[JsonPropertyName("kretaAzonosito")]
		public long? id { get; set; }
		[JsonPropertyName("nev")]
		public string? name { get; set; }
	}
}