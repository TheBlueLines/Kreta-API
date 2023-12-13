/*
	This file is auto generated using Kréta Builder by TheBlueLines
	Generated on: 2023. 12. 13. 21:07:33
*/

using System.Text.Json.Serialization;

namespace TTMC.Kréta
{
	public class MailboxItem
	{
		[JsonPropertyName("isToroltElem")]
		public bool? isDeleted { get; set; }
		[JsonPropertyName("uzenet")]
		public Message? message { get; set; }
		[JsonPropertyName("isElolvasva")]
		public bool? readByUser { get; set; }
		[JsonPropertyName("tipus")]
		public Type? type { get; set; }
		[JsonPropertyName("azonosito")]
		public string? uid { get; set; }
		public class Type
		{
			[JsonPropertyName("kod")]
			public string? typeCode { get; set; }
			[JsonPropertyName("leiras")]
			public string? typeDescription { get; set; }
			[JsonPropertyName("azonosito")]
			public long? typeId { get; set; }
			[JsonPropertyName("nev")]
			public string? typeName { get; set; }
			[JsonPropertyName("rovidNev")]
			public string? typeShortName { get; set; }
		}
	}
}
