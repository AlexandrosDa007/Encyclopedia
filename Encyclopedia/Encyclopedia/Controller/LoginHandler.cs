using Encyclopedia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Encyclopedia.Controller
{
    class LoginHandler
    {
        public String username { set; get; }
        public String password { set; get; }

        public LoginHandler(String username, String password)
        {
            this.username = username;
            this.password = password;
        }

        public bool ValidateAccount()
        {
            String salt = DBConnect.GetSaltByUsername(username);
            String hashedpassword = GenerateSHA256Hash(password, salt);
            //check in database if true then account exits otherwise false
            return DBConnect.Validation(username, hashedpassword);

        }

        public String CreateSalt(int size)
        {
            RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            byte[] buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        public String GenerateSHA256Hash(String input, String salt)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input + salt);
            System.Security.Cryptography.SHA256Managed sha256hashstring = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = sha256hashstring.ComputeHash(bytes);

            return ByteArrayToHexString(hash);
        }

        public String ByteArrayToHexString(byte[] hash)
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
