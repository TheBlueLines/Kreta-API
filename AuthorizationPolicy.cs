using System.Security.Cryptography;
using System.Text;

namespace TTMC.Kréta
{
	public class AuthorizationPolicy
	{
		private HMACSHA512 hmac;
		public readonly string nonce;
		public readonly string key;
		public readonly string version;
		public AuthorizationPolicy(string nonce, string instituteCode, string username, string secret = "baSsxOwlU1jM")
		{
			hmac = new()
			{
				Key = Encoding.ASCII.GetBytes(secret)
			};
			version = "v2";
			this.nonce = nonce;
			byte[] data = Encoding.UTF8.GetBytes(instituteCode.ToUpper() + nonce + username.ToUpper());
			byte[] bytes = hmac.ComputeHash(data);
			key = Convert.ToBase64String(bytes);
		}
	}
}