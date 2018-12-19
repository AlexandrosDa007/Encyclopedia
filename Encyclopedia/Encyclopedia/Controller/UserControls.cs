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
        public static int RegisterUser(string name, string surname, DateTime dateOfBirth, char gender, string tel, string roleName, string educationLevelName, string description, Byte[] image)
        {
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
            try
            {
                User user = new User(-1, name, surname, dateOfBirth, gender, tel, role, educationLevel, description, image);
            }
            catch (ArgumentOutOfRangeException ex)
            {
				Console.WriteLine(ex.ParamName);
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
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.ParamName);
            }

			// if both of the inputs regarding the User and the Account was valid,
			// the registration can continue with the database insertion
			//DBConnect.Insert(user);
			//DBConnect.Insert(new Account());
            return 0;
        }
    }
}
