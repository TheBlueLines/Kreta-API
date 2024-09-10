using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class Institution
	{
		[JsonPropertyName("TestreszabasBeallitasok")]
		public CustomizationSettings? customizationSettings { get; set; }
		[JsonPropertyName("RovidNev")]
		public string? shortName { get; set; }
		[JsonPropertyName("Rendszermodulok")]
		public List<SystemModule>? systemModuleList { get; set; }
		[JsonPropertyName("Uid")]
		public string? uid { get; set; }
		public class CustomizationSettings
		{
			[JsonPropertyName("ErtekelesekMegjelenitesenekKesleltetesenekMerteke")]
			public int delayOfNotifications { get; set; }
			[JsonPropertyName("IsOsztalyAtlagMegjeleniteseEllenorzoben")]
			public bool isClassAverageVisible { get; set; }
			[JsonPropertyName("IsElerhetosegSzerkesztheto")]
			public bool isContactDataEditable { get; set; }
			[JsonPropertyName("IsTanorakTemajaMegtekinthetoEllenorzoben")]
			public bool isLessonsThemeVisible { get; set; }
			[JsonPropertyName("KovetkezoTelepitesDatuma")]
			public string? nextServerDeployAsString { get; set; }
		}
		public class SystemModule
		{
			[JsonPropertyName("IsAktiv")]
			public bool isActive { get; set; }
			[JsonPropertyName("Tipus")]
			public string? type { get; set; }
			[JsonPropertyName("Url")]
			public string? url { get; set; }
		}
	}
}
