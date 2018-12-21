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
					return 2;
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
					return 3;
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
						return 4;
					case "surname":
						return 5;
					case "dateOfBirth":
						return 6;
					case "gender":
						return 7;
					case "tel":
						return 8;
					case "description":
						return 9;
					case "image":
						return 10;
				}
            }

			// if the User is valid
			if (!user.Equals(null))
			{
				// check the input regarding the Account
				// check if the username inserted is unique
				if (!DBConnect.IsAccountUsernameUnique(username))
				{
					return 11;
				}

				// check if the password and the password confirmation are the same
				if (!password.Equals(passwordConfirmation))
				{
					return 12;
				}

				// validate the remaining fields regarding the Account
				Account account = null;
				try
				{
					account = new Account(user, username, password, email, DateTime.Now);
					// TODO validate password
				}
				catch (ArgumentException ex)
				{
					Console.WriteLine(ex.ParamName);
					// some of the Account parameters wasn't valid, check the Account constructor
					switch (ex.ParamName)
					{
						case "username":
							return 13;
						case "password":
							return 14;
						case "email":
							return 15;
					}
				}

				// if both of the inputs regarding the User and the Account were valid,
				// the registration can continue with the database insertion
				if (!account.Equals(null))
				{
					//int rowsAffectedUser = DBConnect.Insert(user);
					//int rowsAffectedAccount = DBConnect.Insert(account);
					// TODO implement Insert(account)
				}
			}
			return 0;
        }
    }
}
