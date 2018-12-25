using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Encyclopedia.Model;

namespace Encyclopedia.Controller
{
    class UserHandler
    {
        public static int RegisterUserAccount(string name, string surname, DateTime dateOfBirth, char gender, string tel, string roleName, string educationLevelName, string description, Byte[] image, string username, string password, string passwordConfirmation, string email)
        {
			// check the input regarding the User
			// check if an education level was selected and if it was, find and construct an EducationLevel object
			EducationLevel educationLevel = null;
			if (!educationLevelName.Equals(""))
			{
				List<EducationLevel> educationLevelList = DBConnect.FindEducationLevel(educationLevelName);
				if (!(educationLevelList.Count() == 1))
				{
					// either there are more than one Education Levels with the same name or there isn't any at all
					return 10;
				}
				educationLevel = educationLevelList.ElementAt(0);
			}
			else
			{
				educationLevel = new EducationLevel(-1, "");
			}

			// check if a role was selected and if it was, find and construct a Role object
			Role role = null;
			if (!roleName.Equals(""))
			{
				List<Role> roleList = DBConnect.FindRole(roleName);
				if (!(roleList.Count() == 1))
				{
					// either there are more than one Roles with the same name or there isn't any at all
					return 11;
				}
				role = roleList.ElementAt(0);
			}
			else
			{
				role = new Role(-1, "");
			}

			// validate the remaining fields regarding the User
			User user = null;
			try
            {
                user = new User(-1, name, surname, dateOfBirth, gender, tel, role, educationLevel, description, image);
            }
            catch (ArgumentException ex)
            {
				Console.WriteLine(ex.ParamName);
				// some of the User parameters wasn't valid, check the User constructor
				switch (ex.ParamName)
				{
					case "name":
						return 12;
					case "surname":
						return 13;
					case "dateOfBirth":
						return 14;
					case "gender":
						return 15;
					case "tel":
						return 16;
					case "description":
						return 17;
					case "image":
						return 18;
				}
            }

			// if the User is valid
			if (!user.Equals(null))
			{
				// check the input regarding the Account
				// check if the username inserted is unique
				if (!DBConnect.IsAccountUsernameUnique(username))
				{
					return 20;
				}

				// check if the email inserted is unique
				if (!DBConnect.IsAccountEmailUnique(email))
				{
					return 21;
				}
				
				string passwordSalt = null;
				string saltedPasswordHash = null;
				// check if the password and the password confirmation are the same
				if (!password.Equals(passwordConfirmation))
				{
					return 22;
				}
				else
				{
					// check if the password has at least 8 characters, one number and one letter (case-insensitive)
					if (password.Length < 8 || !password.Any(char.IsNumber) || !password.Any(char.IsLetter))
					{
						// invalid
						return 23;
					}
					else
					{
						// valid, continue with the salt and the salted password hash creation
						passwordSalt = LoginHandler.CreateSalt(16);
						Console.WriteLine("password salt: " + passwordSalt);
						saltedPasswordHash = LoginHandler.GenerateSHA256Hash(password, passwordSalt);
						Console.WriteLine("salted hash: " + saltedPasswordHash);
					}
				}

				if (!passwordSalt.Equals(null) && !saltedPasswordHash.Equals(null))
				{
					// validate the remaining fields regarding the Account
					Account account = null;
					try
					{
						account = new Account(user, username, saltedPasswordHash, passwordSalt, email, DateTime.Now);
					}
					catch (ArgumentException ex)
					{
						Console.WriteLine(ex.ParamName);
						// some of the Account parameters wasn't valid, check the Account constructor
						switch (ex.ParamName)
						{
							case "username":
								return 25;
							case "saltedPasswordHash":
								return 26;
							case "passwordSalt":
								return 26; // same as the above because it references to the same problem regarding the salt
							case "email":
								return 27;
						}
					}

					// if the Account is valid
					if (!account.Equals(null))
					{
						// if each of the inputs regarding the User and the Account were valid,
						// the registration can continue with the database insertion

						// the exitCode must be equal to 0, otherwise something went wrong with the database
						int exitCode = DBConnect.Insert(user, account);
						if (exitCode == 1)
						{
							// something went wrong with the User insertion in the database - Database Problem
							return 2;
						}
						else if (exitCode == 2)
						{
							// something went wrong with the Account insertion in the database - Database Problem
							return 3;
						}

						// Insertion successful, process terminated with exit code 0
						return 0;
					}
					else
					{
						// something is invalid regarding the Account
						// general error, will propably never occur
						return 28;
					}
				}
				else
				{
					// something went wrong with the salt and the salted password hash creation
					return 24;
				}
			}
			else
			{
				// something is invalid regarding the User
				// general error, will propably never occur
				return 19;
			}
        }
    }
}
