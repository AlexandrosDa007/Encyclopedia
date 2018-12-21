using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encyclopedia.Model;

namespace Encyclopedia.Controller
{
    class UserControls
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

				// check if the password and the password confirmation are the same
				if (!password.Equals(passwordConfirmation))
				{
					return 21;
				}

				// validate the remaining fields regarding the Account
				Account account = null;
				try
				{
					account = new Account(user, username, password, email, DateTime.Now);
					// TODO validate password and alter Account model (saltedPasswordHash, passwordSalt)
				}
				catch (ArgumentException ex)
				{
					Console.WriteLine(ex.ParamName);
					// some of the Account parameters wasn't valid, check the Account constructor
					switch (ex.ParamName)
					{
						case "username":
							return 22;
						case "password":
							return 23;
						case "email":
							return 24;
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
					return 25;
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
