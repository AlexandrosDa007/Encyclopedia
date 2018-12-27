using System;
using System.Security.Cryptography;
using System.Text;

namespace Encyclopedia.Controller
{
	class PasswordUtilities
	{
		public static String CreateSalt(int size)
		{
			RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
			byte[] buffer = new byte[size];
			rng.GetBytes(buffer);
			return Convert.ToBase64String(buffer);
		}

		public static String GenerateSHA256Hash(String input, String salt)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(input + salt);

			SHA256Managed sha256hashstring = new SHA256Managed();
			byte[] hash = sha256hashstring.ComputeHash(bytes);

			return ByteArrayToHexString(hash);
		}

		private static String ByteArrayToHexString(byte[] hash)
		{
			StringBuilder hex = new StringBuilder(hash.Length * 2);
			foreach (byte h in hash)
			{
				hex.AppendFormat("{0:x2}", h);
			}

			return hex.ToString();
		}
	}
}
