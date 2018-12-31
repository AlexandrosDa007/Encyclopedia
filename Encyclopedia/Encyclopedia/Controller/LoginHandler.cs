using System;

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
			String hashedpassword = PasswordUtilities.GenerateSHA256Hash(password, salt);
			
            //check in database if true then account exists otherwise false
            return DBConnect.LoginValidation(username, hashedpassword);
        }
    }
}
