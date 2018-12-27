using System;

namespace Encyclopedia.Controller
{
    class LoginHandler
    {
        private String username;
        private String password;

        public LoginHandler(String username, String password)
        {
            this.username = username;
            this.password = password;
        }

        public bool ValidateAccount()
        {
            String salt = PasswordUtilities.CreateSalt(10);
            String hashedpassword = PasswordUtilities.GenerateSHA256Hash(password, salt);

            // check in database if true then account exists otherwise false
            return DBConnect.Validation(username, hashedpassword);
        }
    }
}
