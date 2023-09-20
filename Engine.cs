using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Text.Unicode;

namespace TTMC.Kréta
{
	internal class Engine
	{
		public static JsonSerializerOptions jsonSerializerOptions = new()
		{
			WriteIndented = false,
			Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
			DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
		};
	}
}
