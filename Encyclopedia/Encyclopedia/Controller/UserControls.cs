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
        public static int RegisterUser(string name, string surname, DateTime dateOfBirth, char gender, int tel, Role role, EducationLevel educationLevel, string description, Byte[] image)
        {
            DBConnect.Initialize();

            // validate inputs
            try
            {
                User user = new User(-1, name, surname, dateOfBirth, gender, tel, role, educationLevel, description, image);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message + " " + ex.ParamName);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message + " " + ex.ParamName);
            }


            DBConnect.CloseConnection();
            return 0;
        }
    }
}
