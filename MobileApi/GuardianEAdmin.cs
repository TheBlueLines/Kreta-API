using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class GuardianEAdmin
	{
		[JsonPropertyName("tanuloOsztalyKretaAzonosito")]
		public long classId { get; set; }
		[JsonPropertyName("emailCim")]
		public string? emailAddress { get; set; }
		[JsonPropertyName("gondviseloNev")]
		public string? guardianName { get; set; }
		[JsonPropertyName("isTorvenyesKepviselo")]
		public bool isLegalRepresentative { get; set; }
		[JsonPropertyName("isSZMK")]
		public bool isSzmk { get; set; }
		[JsonPropertyName("isSZMKHelyettes")]
		public bool isSzmkDeputy { get; set; }
		[JsonPropertyName("kretaAzonosito")]
		public long kretaId { get; set; }
		[JsonPropertyName("rokonsagiFok")]
		public string? relationType { get; set; }
		[JsonPropertyName("tanuloOsztaly")]
		public string? studentClass { get; set; }
		[JsonPropertyName("tanuloOktatasiAzonosito")]
		public string? studentId { get; set; }
		[JsonPropertyName("tanuloNev")]
		public string? studentName { get; set; }
		[JsonPropertyName("SZMKOsztaly")]
		public string? szmkClass { get; set; }
		[JsonPropertyName("sZMKOsztalyHelyettes")]
		public string? szmkClassDeputy { get; set; }
		[JsonPropertyName("sZMKOsztalyHelyettesKretaAzonosito")]
		public long szmkClassDeputyKretaId { get; set; }
		[JsonPropertyName("sZMKOsztalyKretaAlkalmazott")]
		public long szmkClassKretaEmployee { get; set; }
		[JsonPropertyName("sZMKOsztalyKretaAzonosito")]
		public long szmkClassKretaId { get; set; }
	}
}
