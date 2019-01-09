using System;

namespace Encyclopedia.Controller
{
    /// <summary>
    /// Contains function to validate the user when he/she gives information in the textboxes.
    /// </summary>
    class LoginHandler
    {
        /// <summary>
        /// The username of the User that is trying to log in.
        /// </summary>
        public String username { set; get; }
        /// <summary>
        /// The password of the User that is trying to log in.
        /// </summary>
        public String password { set; get; }
        /// <summary>
        /// Takes a username and password and sets then to the properties.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public LoginHandler(String username, String password)
        {
            this.username = username;
            this.password = password;
        }
        /// <summary>
        /// Validates the account uses a SHA256 hash and salt to check if password mathces.
        /// Returns true if account matches.
        /// </summary>
        /// <returns></returns>
        public bool ValidateAccount()
        {
			String salt = DBConnect.GetSaltByUsername(username);
			String hashedpassword = PasswordUtilities.GenerateSHA256Hash(password, salt);
			
            //check in database if true then account exists otherwise false
            return DBConnect.LoginValidation(username, hashedpassword);
        }
    }
}
