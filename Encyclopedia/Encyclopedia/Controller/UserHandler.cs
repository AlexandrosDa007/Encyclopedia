using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Encyclopedia.Model;

namespace Encyclopedia.Controller
{
    class UserHandler
    {
		public static int SendTempPasswordToAccountEmail(string emailAddress)
		{
			try
			{
				MailMessage mail = new MailMessage("encyclopedia.noreply@gmail.com", emailAddress);
				SmtpClient client = new SmtpClient();
				client.Port = 25;
				client.DeliveryMethod = SmtpDeliveryMethod.Network;
				client.EnableSsl = true;
				client.UseDefaultCredentials = false;
				client.Credentials = new System.Net.NetworkCredential("ΟΜΑΔΑ4 ΑΔΟΠΣΕ", "mpla123P");
				client.Host = "smtp.gmail.com";

				mail.Subject = "Encyclopedia Password Recovery";
				mail.IsBodyHtml = true;
				mail.Body = "this is my test email body";
				client.Send(mail);
			}
			catch (Exception)
			{
				return 2;
			}

			return 0;
		}

        public static int RegisterUserAccount(string name, string surname, DateTime dateOfBirth, char gender, string tel, string roleName, string educationLevelName, string description, Byte[] image, string username, string password, string passwordConfirmation, string email)
        {
			// check the input regarding the User
			// check if an education level was selected and if it was, find and construct an EducationLevel object
			EducationLevel educationLevel = FindEducationLevel(educationLevelName);

			// check if a role was selected and if it was, find and construct a Role object
			Role role = FindRole(roleName);

			// validate the remaining fields regarding the User
			Dictionary<string, Object> userDict = VerifyUser(name, surname, dateOfBirth, gender, tel, role, educationLevel, description, image);

			if (!userDict["exitCode"].Equals("0"))
			{
				return Convert.ToInt32(userDict["exitCode"]);
			}
			else
			{
				// the User is valid
				User user = (User)userDict["user"];

				// check the input regarding the Account
				// check if the email inserted is unique
				if (!DBConnect.IsAccountEmailUnique(email))
				{
					return 20;
				}

				// check if the username inserted is unique
				if (!DBConnect.IsAccountUsernameUnique(username))
				{
					return 21;
				}

				// check if password is valid and if it does construct the salt and the salted password hash
				Dictionary<string, string> passwordDict = VerifyPassword(password, passwordConfirmation);

				if (!passwordDict["exitCode"].Equals("0"))
				{
					return Convert.ToInt32(passwordDict["exitCode"]);
				}
				else
				{
					// validate the remaining fields regarding the Account
					Dictionary<string, Object> accountDict = VerifyAccount(user, username, passwordDict["saltedPasswordHash"], passwordDict["passwordSalt"], email);

					if (!accountDict["exitCode"].Equals("0"))
					{
						return Convert.ToInt32(accountDict["exitCode"]);
					}
					else
					{
						// the Account is valid
						Account account = (Account)accountDict["account"];

						// if each of the inputs regarding the User and the Account were valid,
						// the registration can continue with the database insertion

						// the exitCode must be equal to 0, otherwise something went wrong with the database
						int exitCode = DBConnect.Insert(user, account);

						// if it was 2, something went wrong with the User insertion in the database - Database Problem
						// if it was 3, something went wrong with the Account insertion in the database - Database Problem
						// else successful insertion, process terminated with exit code 0
						return exitCode;
					}
				}
			}
        }



		private static EducationLevel FindEducationLevel(string educationLevelName)
		{
			EducationLevel educationLevel = null;
			if (!educationLevelName.Equals(""))
			{
				List<EducationLevel> educationLevelList = DBConnect.FindEducationLevel(educationLevelName);
				if (!(educationLevelList.Count() == 1))
				{
					// either there are more than one Education Levels with the same name or there isn't any at all
					return null;
				}
				educationLevel = educationLevelList.ElementAt(0);
			}

			return educationLevel;
		}

		private static Role FindRole(string roleName)
		{
			Role role = null;
			if (!roleName.Equals(""))
			{
				List<Role> roleList = DBConnect.FindRole(roleName);
				if (!(roleList.Count() == 1))
				{
					// either there are more than one Roles with the same name or there isn't any at all
					return null;
				}
				role = roleList.ElementAt(0);
			}

			return role;
		}

		private static Dictionary<string, Object> VerifyUser(string name, string surname, DateTime dateOfBirth, char gender, string tel, Role role, EducationLevel educationLevel, string description, Byte[] image)
		{
			Dictionary<string, Object> dict = new Dictionary<string, Object>();

			User user = null;
			try
			{
				user = new User(-1, name, surname, dateOfBirth, gender, tel, role, educationLevel, description, image);

				dict.Add("user", user);
				dict.Add("exitCode", "0");
			}
			catch (ArgumentException ex)
			{
				// some of the User parameters wasn't valid, check the User constructor
				switch (ex.ParamName)
				{
					case "name":
						dict.Add("exitCode", "10");
						break;
					case "surname":
						dict.Add("exitCode", "11");
						break;
					case "dateOfBirth":
						dict.Add("exitCode", "12");
						break;
					case "gender":
						dict.Add("exitCode", "13");
						break;
					case "tel":
						dict.Add("exitCode", "14");
						break;
					case "description":
						dict.Add("exitCode", "15");
						break;
					case "image":
						dict.Add("exitCode", "16");
						break;
				}
			}

			return dict;
		}

		private static Dictionary<string, string> VerifyPassword(string password, string passwordConfirmation)
		{
			Dictionary<string, string> dict = new Dictionary<string, string>();
			
			// check if the password and the password confirmation are the same
			if (!password.Equals(passwordConfirmation))
			{
				dict.Add("exitCode", "22");
			}
			else
			{
				// check if the password has at least 8 characters, one number and one letter (case-insensitive)
				if (password.Length < 8 || !password.Any(char.IsNumber) || !password.Any(char.IsLetter))
				{
					// invalid
					dict.Add("exitCode", "23");
				}
				else
				{
					// valid, continue with the salt and the salted password hash creation
					dict.Add("passwordSalt", PasswordUtilities.CreateSalt(16));
					
					dict.Add("saltedPasswordHash", PasswordUtilities.GenerateSHA256Hash(password, dict["passwordSalt"]));

					dict.Add("exitCode", "0");
				}
			}

			return dict;
		}

		private static Dictionary<string, Object> VerifyAccount(User user, string username, string saltedPasswordHash, string passwordSalt, string email)
		{
			Dictionary<string, Object> dict = new Dictionary<string, Object>();

			Account account = null;
			try
			{
				account = new Account(user, username, saltedPasswordHash, passwordSalt, email, DateTime.Now);

				dict.Add("account", account);
				dict.Add("exitCode", "0");
			}
			catch (ArgumentException ex)
			{
				// some of the Account parameters wasn't valid, check the Account constructor
				switch (ex.ParamName)
				{
					case "username":
						dict.Add("exitCode", "24");
						break;
					case "saltedPasswordHash":
						dict.Add("exitCode", "25");
						break;
					case "passwordSalt":
						dict.Add("exitCode", "25"); // same as the above because it references to the same problem regarding the salt
						break;
					case "email":  // null or empty email input string
						dict.Add("exitCode", "26");
						break;
				}
			}
			catch (FormatException)
			{
				// invalid email address, wrong format
				dict.Add("exitCode", "27");
			}

			return dict;
		}

	}
}
