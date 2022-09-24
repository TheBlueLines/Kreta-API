using System.Text.Json;

namespace TTMC.Kréta
{
	public class One
	{
		public string? Uid { get; set; }
	}
	public class Two
	{
		public string? Uid { get; set; }
		public string? Nev { get; set; }
	}
	public class Three
	{
		public string? Uid { get; set; }
		public string? Nev { get; set; }
		public string? Leiras { get; set; }
	}
	public class Four
	{
		public string? Uid { get; set; }
		public string? Nev { get; set; }
		public Three? Kategoria { get; set; }
		public byte? SortIndex { get; set; }
	}
	public class Institute
	{
		public ushort instituteId { get; set; }
		public string? instituteCode { get; set; }
		public string? name { get; set; }
		public string? city { get; set; }
		public string? url { get; set; }
		public string? advertisingUrl { get; set; }
		public string? informationImageUrl { get; set; }
		public string? informationUrl { get; set; }
	}
	public class LoginDetails
	{
		public string? id_token { get; set; }
		public string? access_token { get; set; }
		public int expires_in { get; set; }
		public string? token_type { get; set; }
		public string? refresh_token { get; set; }
		public string? scope { get; set; }
	}
	public class Message
	{
		public Account? account { get; set; }
		public int azonosito { get; set; }
		public int uzenetAzonosito { get; set; }
		public string? uzenetKuldesDatum { get; set; }
		public string? uzenetFeladoNev { get; set; }
		public string? uzenetFeladoTitulus { get; set; }
		public string? uzenetTargy { get; set; }
		public bool hasCsatolmany { get; set; }
		public bool isElolvasva { get; set; }
		public MessagePlus GetInformation()
		{
			if (account != null)
			{
				string json = account.client.GetStringAsync("https://eugyintezes.e-kreta.hu/api/v1/kommunikacio/postaladaelemek/" + azonosito).Result;
				MessagePlus? plus = JsonSerializer.Deserialize<MessagePlus>(json);
				if (plus != null)
				{
					return plus;
				}
			}
			return new();
		}
	}
	public class MessagePlus
	{
		public int azonosito { get; set; }
		public bool isElolvasva { get; set; }
		public bool isToroltElem { get; set; }
		public MessageHelp? tipus { get; set; }
		public MessageMore? uzenet { get; set; }
	}
	public class MessageMore
	{
		public int azonosito { get; set; }
		public string? kuldesDatum { get; set; }
		public string? feladoNev { get; set; }
		public string? feladoTitulus { get; set; }
		public string? szoveg { get; set; }
		public string? targy { get; set; }
		public MessageHelp? statusz { get; set; }
		public List<MessageMembers>? cimzettLista { get; set; }
		public List<MessageAttachments>? csatolmanyok { get; set; }
	}
	public class MessageMembers
	{
		public int azonosito { get; set; }
		public int kretaAzonosito { get; set; }
		public string? nev { get; set; }
		public MessageHelp? tipus { get; set; }
	}
	public class MessageHelp
	{
		public int azonosito { get; set; }
		public string? kod { get; set; }
		public string? rovidNev { get; set; }
		public string? nev { get; set; }
		public string? leiras { get; set; }
	}
	public class MessageAttachments
	{
		public int azonosito { get; set; }
		public string? fajlNev { get; set; }
	}
	public class Exam
	{
		public string? Uid { get; set; }
		public string? Datum { get; set; }
		public string? BejelentesDatuma { get; set; }
		public string? RogzitoTanarNeve { get; set; }
		public int? OrarendiOraOraszama { get; set; }
		public Four? Tantargy { get; set; }
		public string? TantargyNeve { get; set; }
		public string? Temaja { get; set; }
		public Three? Modja { get; set; }
		public One? OsztalyCsoport { get; set; }
	}
	public class Timetable
	{
		public string? Uid { get; set; }
		public string? Datum { get; set; }
		public string? KezdetIdopont { get; set; }
		public string? VegIdopont { get; set; }
		public string? Nev { get; set; }
		public int? Oraszam { get; set; }
		public int? OraEvesSorszama { get; set; }
		public Two? OsztalyCsoport { get; set; }
		public string? TanarNeve { get; set; }
		public Four? Tantargy { get; set; }
		public string? Tema { get; set; }
		public string? TeremNeve { get; set; }
		public Three? Tipus { get; set; }
		public Three? TanuloJelenlet { get; set; }
		public Three? Allapot { get; set; }
		public string? HelyettesTanarNeve { get; set; }
		public string? HaziFeladatUid { get; set; }
		public string? FeladatGroupUid { get; set; }
		public string? NyelviFeladatGroupUid { get; set; }
		public string? BejelentettSzamonkeresUid { get; set; }
		public bool? IsTanuloHaziFeladatEnabled { get; set; }
		public bool? IsHaziFeladatMegoldva { get; set; }
		public List<MessageAttachments>? Csatolmanyok { get; set; }
		public bool? IsDigitalisOra { get; set; }
		public string? DigitalisEszkozTipus { get; set; }
		public string? DigitalisPlatformTipus { get; set; }
		public List<string>? DigitalisTamogatoEszkozTipusList { get; set; }
		public string? Letrehozas { get; set; }
		public string? UtolsoModositas { get; set; }
	}
	public class StudentInfo
	{
		public string? Uid { get; set; }
		public string? IdpUniqueId { get; set; }
		public string? TanevUid { get; set; }
		public string? IntezmenyNev { get; set; }
		public string? IntezmenyAzonosito { get; set; }
		public string? Nev { get; set; }
		public string? SzuletesiNev { get; set; }
		public string? SzuletesiHely { get; set; }
		public string? AnyjaNeve { get; set; }
		public string? Telefonszam { get; set; }
		public string? EmailCim { get; set; }
		public List<string>? Cimek { get; set; }
		public string? SzuletesiDatum { get; set; }
		public ushort? SzuletesiEv { get; set; }
		public ushort? SzuletesiHonap { get; set; }
		public ushort? SzuletesiNap { get; set; }
		public bool? IsEszkozKiosztva { get; set; }
		public List<Gondviselo>? Gondviselok { get; set; }
		public Bank? Bankszamla { get; set; }
		public Intezmeny? Intezmeny { get; set; }
	}
	public class Gondviselo
	{
		public string? Uid { get; set; }
		public string? IdpUniqueId { get; set; }
		public string? Nev { get; set; }
		public string? EmailCim { get; set; }
		public string? Telefonszam { get; set; }
		public bool? IsTorvenyesKepviselo { get; set; }
	}
	public class Bank
	{
		public string? BankszamlaSzam { get; set; }
		public ushort? BankszamlaTulajdonosTipusId { get; set; }
		public string? BankszamlaTulajdonosNeve { get; set; }
		public bool? IsReadOnly { get; set; }
	}
	public class Intezmeny
	{
		public string? Uid { get; set; }
		public string? RovidNev { get; set; }
		public List<Rendszermodul>? Rendszermodulok { get; set; }
		public TestreszabasBeallitasok? TestreszabasBeallitasok { get; set; }
	}
	public class Rendszermodul
	{
		public bool IsAktiv { get; set; }
		public string? Tipus { get; set; }
		public string? Url { get; set; }
	}
	public class TestreszabasBeallitasok
	{
		public bool IsDiakRogzithetHaziFeladatot { get; set; }
		public bool IsTanorakTemajaMegtekinthetoEllenorzoben { get; set; }
		public bool IsOsztalyAtlagMegjeleniteseEllenorzoben { get; set; }
		public int ErtekelesekMegjelenitesenekKesleltetesenekMerteke { get; set; }
		public string? KovetkezoTelepitesDatuma { get; set; }
	}
	public class Absences
	{
		public string? Uid { get; set; }
		public Four? Tantargy { get; set; }
		public Ora? Ora { get; set; }
		public string? Datum { get; set; }
		public string? RogzitoTanarNeve { get; set; }
		public Three? Tipus { get; set; }
		public Three? Mod { get; set; }
		public int? KesesPercben { get; set; }
		public string? KeszitesDatuma { get; set; }
		public string? IgazolasAllapota { get; set; }
		public string? IgazolasTipusa { get; set; }
		public One? OsztalyCsoport { get; set; }
	}
	public class Ora
	{
		public string? KezdoDatum { get; set; }
		public string? VegDatum { get; set; }
		public int? Oraszam { get; set; }
	}
	public class Evaluations
	{
		public string? Uid { get; set; }
		public string? RogzitesDatuma { get; set; }
		public string? KeszitesDatuma { get; set; }
		public string? LattamozasDatuma { get; set; }
		public Four? Tantargy { get; set; }
		public string? Tema { get; set; }
		public Three? Tipus { get; set; }
		public Three? Mod { get; set; }
		public Three? ErtekFajta { get; set; }
		public string? ErtekeloTanarNeve { get; set; }
		public string? Jelleg { get; set; }
		public byte? SzamErtek { get; set; }
		public string? SzovegesErtek { get; set; }
		public ushort? SulySzazalekErteke { get; set; }
		public string? SzovegesErtekelesRovidNev { get; set; }
		public One? OsztalyCsoport { get; set; }
		public byte? SortIndex { get; set; }
	}
}