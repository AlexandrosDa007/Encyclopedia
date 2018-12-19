using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encyclopedia.Model;
using MySql.Data.MySqlClient;

namespace Encyclopedia.Controller
{
    class DBConnect
    {
        public static MySqlConnection connection;
        public static string server;
        public static string database;
        public static string uid;
        public static string password;

       

        public static void Initialize()
        {
            server = "83.212.103.59";
            database = "foo";
            uid = "user1";
            password = "1234567890";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            OpenConnection();
        }

        //open connection to database
        public static bool OpenConnection()
        {
            
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server. Contact Admin");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        public static bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        //Select

        public static Byte[] GetLemmaBodyByTitle(string lemmaTitle)
        {
            Byte[] lemmaBody = new byte[10000];
            string query = "SELECT lemma_body FROM Lemma WHERE lemma_title = '" + lemmaTitle + "'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                lemmaBody = Encoding.UTF8.GetBytes(dataReader.GetString("lemma_body"));
            }

            dataReader.Close();
            return lemmaBody;
        }

        public static List<Lemma> GetAllLemma()
        {
            List<Lemma> lemmaList = new List<Lemma>();

            string query = "SELECT * FROM Lemma";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandTimeout = 500000;
            MySqlDataReader dataReader = cmd.ExecuteReader();
            int i = 0;
            while (dataReader.Read())
            {
                Console.WriteLine(i);
                Lemma lemma = new Lemma(dataReader[0].ToString(), Encoding.UTF8.GetBytes(dataReader[1].ToString()), Convert.ToInt32(dataReader[2].ToString()));
                lemmaList.Add(lemma);
                i++;
            }
            dataReader.Close();
            return lemmaList;
        }

        public static List<string> GetLemmaTitleByCategoryName(string categoryName)
        {
            string query = "SELECT category_id FROM Category WHERE category_name = '" + categoryName + "'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandTimeout = 500000;
            MySqlDataReader dataReader = cmd.ExecuteReader();
            int id = -1;
            while (dataReader.Read())
            {
                id = Convert.ToInt32(dataReader[0].ToString());
            }

            Category category = new Category(id, categoryName);
            List<string> titleList = new List<string>();

            dataReader.Close();

            query = "SELECT lemma_title FROM Lemma L JOIN Category C ON L.category_id = C.category_id WHERE C.category_id = " + category.Id;
            cmd = new MySqlCommand(query, connection);
            cmd.CommandTimeout = 500000;
            
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                titleList.Add(dataReader[0].ToString());
            }

            Console.WriteLine(titleList.Count);
            dataReader.Close();
            return titleList;
        }

        //insert

        public int Insert(Account account)
        {
            //code to insert new account
            return 1;
        }

        public int Insert(Category category)
        {
            //code to insert new category
            return 1;
        }

        public int Insert(Contact contact)
        {
            //code to insert new contact
            return 1;
        }

        public int Insert(ContactGroup contactGroup)
        {
            //code to insert contactgroup
            return 1;
        }

        public int Insert(EditedLemma editedLemma)
        {
            //code to insert editedLemma
            return 1;
        }

        public int Insert(EducationLevel educationLevel)
        {
            //code to insert educationLevel
            return 1;
        }

        public int Insert(FavoriteLemma favoriteLemma)
        {
            //code to insert favoriteLemma
            return 1;
        }

        public int Insert(Lemma lemma)
        {
            //code to insert lemma
            return 1;
        }

        public int Insert(Role role)
        {
            //code to insert role
            return 1;
        }

        public int Insert(SharedLemma sharedLemma)
        {
            //code to insert sharedLemma
            return 1;
        }

        public int Insert(User user)
        {
            // prepare query string
            string insertFields = "INSERT INTO " +
                "User (user_name, user_surname, user_date_of_birth";
            string insertValues = "VALUES(@name, @surname, @dateOfBirth";

            // check if fields aren't null
            if (!user.Gender.Equals("-"))
            {
                insertFields += ", user_gender";
                insertValues += ", @gender";
            }
            if (!user.Tel.Equals(-1))
            {
                insertFields += ", user_tel";
                insertValues += ", @tel";
            }
            if (!user.Role.Equals(null))
            {
                insertFields += ", user_role_id";
                insertValues += ", @roleId";
            }
            if (!user.EducationLevel.Equals(null))
            {
                insertFields += ", user_education_level_id";
                insertValues += ", @educationLevel";
            }
            if (!user.Description.Equals(null))
            {
                insertFields += ", user_description";
                insertValues += ", @description";
            }
            if (!user.Image.Equals(null))
            {
                insertFields += ", user_image";
                insertValues += ", @image";
            }
            string insertUser = insertFields + ") " + insertValues + ") ";
            
            MySqlCommand cmd = new MySqlCommand(insertUser, connection);
            cmd.CommandTimeout = 500000;

            // add values to the parameters
            cmd.Parameters.AddWithValue("@name", user.Name);
            cmd.Parameters.AddWithValue("@surname", user.Surname);
            cmd.Parameters.AddWithValue("@dateOfBirth", user.DateOfBirth);
            if (!user.Gender.Equals("-"))
            {
                cmd.Parameters.AddWithValue("@gender", user.Gender);
            }
            if (!user.Tel.Equals(-1))
            {
                cmd.Parameters.AddWithValue("@tel", user.Tel);
            }
            if (!user.Role.Equals(null))
            {
                cmd.Parameters.AddWithValue("@roleId", user.Role.Id);
            }
            if (!user.EducationLevel.Equals(null))
            {
                cmd.Parameters.AddWithValue("@educationLevel", user.EducationLevel.Id);
            }
            if (!user.Description.Equals(null))
            {
                cmd.Parameters.AddWithValue("@description", user.Description);
            }
            if (!user.Image.Equals(null))
            {
                cmd.Parameters.AddWithValue("@image", Encoding.UTF8.GetBytes(user.Image.ToString()));
            }

            // prepare and execute
            cmd.Prepare();
            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected; // if rowsAffected equals to 1, then the insertion completed successfully
        }

        //delete

        public void Delete(Account account)
        {
            //code to Delete new account
        }

        public void Delete(Category category)
        {
            //code to Delete new category
        }

        public void Delete(Contact contact)
        {
            //code to Delete new contact
        }

        public void Delete(ContactGroup contactGroup)
        {
            //code to Delete contactgroup
        }

        public void Delete(EditedLemma editedLemma)
        {
            //code to Delete editedLemma
        }

        public void Delete(EducationLevel educationLevel)
        {
            //code to Delete educationLevel
        }

        public void Delete(FavoriteLemma favoriteLemma)
        {
            //code to Delete favoriteLemma
        }

        public void Delete(Lemma lemma)
        {
            //code to Delete lemma
        }

        public void Delete(Role role)
        {
            //code to Delete role
        }

        public void Delete(SharedLemma sharedLemma)
        {
            //code to Delete sharedLemma
        }

        public void Delete(User user)
        {
            //code to Delete user
        }

        //update

        public void Update(Account account)
        {
            //code to Update new account
        }

        public void Update(Category category)
        {
            //code to Update new category
        }

        public void Update(Contact contact)
        {
            //code to Update new contact
        }

        public void Update(ContactGroup contactGroup)
        {
            //code to Update contactgroup
        }

        public void Update(EditedLemma editedLemma)
        {
            //code to Update editedLemma
        }

        public void Update(EducationLevel educationLevel)
        {
            //code to Update educationLevel
        }

        public void Update(FavoriteLemma favoriteLemma)
        {
            //code to Update favoriteLemma
        }

        public void Update(Lemma lemma)
        {
            //code to Update lemma
        }

        public void Update(Role role)
        {
            //code to Update role
        }

        public void Update(SharedLemma sharedLemma)
        {
            //code to Update sharedLemma
        }

        public void Update(User user)
        {
            //code to Update user
        }
    }

    
}
