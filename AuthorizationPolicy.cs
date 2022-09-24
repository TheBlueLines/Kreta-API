using System.Security.Cryptography;
using System.Text;

namespace TTMC.Kréta
{
	public class AuthorizationPolicy
	{
		private HMACSHA512 hmac = new();
		public string nonce = string.Empty;
		public string key = string.Empty;
		public string version = "v2";
		private readonly string code = "baSsxOwlU1jM";
		public AuthorizationPolicy(string instituteCode, string username)
		{
			hmac.Key = Encoding.ASCII.GetBytes(code);
			nonce = new HttpClient().GetStringAsync("https://idp.e-kreta.hu/nonce").Result;
			byte[] data = Encoding.UTF8.GetBytes(instituteCode.ToUpper() + nonce + username.ToUpper());
			byte[] bytes = hmac.ComputeHash(data);
			key = Convert.ToBase64String(bytes);
		}
	}
}