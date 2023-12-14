using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Addressee
	{
		[JsonPropertyName("azonosito")]
		public string? id { get; set; }
		[JsonPropertyName("kretaAzonosito")]
		public long kretaId { get; set; }
		[JsonPropertyName("nev")]
		public string? name { get; set; }
		[JsonPropertyName("tipus")]
		public Type? type { get; set; }
		public class Type
		{
			[JsonPropertyName("kod")]
			public string? typeCode { get; set; }
			[JsonPropertyName("leiras")]
			public string? typeDescription { get; set; }
			[JsonPropertyName("azonosito")]
			public long typeId { get; set; }
			[JsonPropertyName("nev")]
			public string? typeName { get; set; }
			[JsonPropertyName("rovidNev")]
			public string? typeShortName { get; set; }
		}
	}
}
