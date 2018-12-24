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


        public static void Initialize()
        {
            connection = new MySqlConnection(Encyclopedia.Properties.Settings.Default.fooConnectionString);
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
                        Console.WriteLine("Cannot connect to server. Contact Admin.");
                        break;
                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again.");
                        break;
					default:
						Console.WriteLine("Error Number " + ex.Number + ": " + ex.Message);
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

        public static bool Validation(String username, String password)
        {
            string query = "SELECT username,password FROM Account WHERE username='"+username+"' AND password='"+password+"'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            int i = 0;
            while (dataReader.Read())
            {
                i++;
            }
            dataReader.Close();
            if (i > 0)
                return true;
            return false;
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

		public static List<int> GetCategoryIdByName(List<string> categoryNameList)
		{
			List<int> categoryIdList = new List<int>();
			foreach (string name in categoryNameList)
			{
				string query = "SELECT category_id from Category WHERE category_name = '" + name + "'";
				MySqlCommand cmd = new MySqlCommand(query, connection);
				cmd.CommandTimeout = 500000;
				MySqlDataReader dataReader = cmd.ExecuteReader();
				while (dataReader.Read())
				{
					categoryIdList.Add(Convert.ToInt32(dataReader[0].ToString()));
				}
				dataReader.Close();
			}
			Console.WriteLine(categoryIdList.Count);
			return categoryIdList;
		}

		public static List<EducationLevel> FindEducationLevel(string educationLevelName)
        {
            List<EducationLevel> educationLevelList = new List<EducationLevel>();
            // construct query
            string selectQuery = "SELECT * FROM Education_Level where education_level_name = @name";
            MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
            cmd.Parameters.AddWithValue("@name", educationLevelName);
            cmd.CommandTimeout = 500000;

            // prepare and execute
            cmd.Prepare();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                EducationLevel educationLevel = new EducationLevel(Convert.ToInt32(dataReader["education_level_id"]), dataReader["education_level_name"].ToString());
                educationLevelList.Add(educationLevel);
            }

            dataReader.Close();
            return educationLevelList;
        }

		public static string[] GetEducationLevels()
		{
			List<string> educationLevelList = new List<string>();
			// construct query
			string selectQuery = "SELECT education_level_name FROM Education_Level";
			MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
			cmd.CommandTimeout = 500000;

			// prepare and execute
			cmd.Prepare();
			MySqlDataReader dataReader = cmd.ExecuteReader();
			
			while (dataReader.Read())
			{
				educationLevelList.Add(dataReader["education_level_name"].ToString());
			}

			string[] educationLevelArray = educationLevelList.ToArray();
			dataReader.Close();
			return educationLevelArray;
		}

		public static List<Role> FindRole(string roleName)
        {
            List<Role> roleList = new List<Role>();
            // construct query
            string selectQuery = "SELECT * FROM Role where role_name = @name";
            MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
            cmd.Parameters.AddWithValue("@name", roleName);
            cmd.CommandTimeout = 500000;

            // prepare and execute
            cmd.Prepare();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Role role = new Role(Convert.ToInt32(dataReader["role_id"]), dataReader["role_name"].ToString());
                roleList.Add(role);
            }

            dataReader.Close();
            return roleList;
        }

		public static string[] GetRoles()
		{
			List<string> roleList = new List<string>();
			// construct query
			string selectQuery = "SELECT role_name FROM Role";
			MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
			cmd.CommandTimeout = 500000;

			// prepare and execute
			cmd.Prepare();
			MySqlDataReader dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				roleList.Add(dataReader["role_name"].ToString());
			}

			string[] roleArray = roleList.ToArray();
			dataReader.Close();
			return roleArray;
		}

		public static bool IsAccountUsernameUnique(string username)
		{
			bool isUnique = true;

			// construct query
			string selectQuery = "SELECT account_username FROM Account WHERE account_username = @username";
			MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
			cmd.Parameters.AddWithValue("@username", username);
			cmd.CommandTimeout = 500000;

			// prepare and execute
			cmd.Prepare();
			MySqlDataReader dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				isUnique = false;
			}

			dataReader.Close();
			return isUnique;
		}

		public static bool IsAccountEmailUnique(string email)
		{
			bool isUnique = true;

			// construct query
			string selectQuery = "SELECT account_email FROM Account WHERE account_email = @email";
			MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
			cmd.Parameters.AddWithValue("@email", email);
			cmd.CommandTimeout = 500000;

			// prepare and execute
			cmd.Prepare();
			MySqlDataReader dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				isUnique = false;
			}

			dataReader.Close();
			return isUnique;
		}

		//insert

		public static int Insert(Category category)
        {
            //code to insert new category
            return 1;
        }

        public static int Insert(Contact contact)
        {
            //code to insert new contact
            return 1;
        }

        public static int Insert(ContactGroup contactGroup)
        {
            //code to insert contactgroup
            return 1;
        }

        public static int Insert(EditedLemma editedLemma)
        {
            //code to insert editedLemma
            return 1;
        }

        public static int Insert(EducationLevel educationLevel)
        {
            //code to insert educationLevel
            return 1;
        }

        public static int Insert(FavoriteLemma favoriteLemma)
        {
            //code to insert favoriteLemma
            return 1;
        }

        public static int Insert(Lemma lemma)
        {
            //code to insert lemma
            return 1;
        }

        public static int Insert(Role role)
        {
            //code to insert role
            return 1;
        }

        public static int Insert(SharedLemma sharedLemma)
        {
            //code to insert sharedLemma
            return 1;
        }

		public static int Insert(User user, Account account)
		{
			int userId = Insert(user);
			// if the userId remained -1, it means that the insertion was unsuccessful
			if (userId != -1)
			{
				account.User.Id = userId;
				Console.WriteLine(account.User.Id);

				// if rowsAffectedAccount equals to 1, then the insertion completed successfully
				int rowsAffectedAccount = Insert(account);
				if (rowsAffectedAccount != 1)
				{
					return 2;
				}
			}
			else
			{
				return 1;
			}

			// if the method doesn't return 0, something went wrong with the database
			return 0;
		}

		public static int Insert(User user)
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
            if (!user.Tel.Equals("__________") || !user.Tel.Equals(null))
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
            if (!user.Description.Equals("") || !user.Description.Equals(null))
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
			Console.WriteLine(insertUser);

			MySqlCommand cmd = new MySqlCommand(insertUser, connection);
            cmd.CommandTimeout = 500000;

            // add values to the parameters
            cmd.Parameters.AddWithValue("@name", user.Name);
            cmd.Parameters.AddWithValue("@surname", user.Surname);
            cmd.Parameters.AddWithValue("@dateOfBirth", user.DateOfBirth.Date);
            if (!user.Gender.Equals("-"))
            {
                cmd.Parameters.AddWithValue("@gender", user.Gender);
            }
            if (!user.Tel.Equals("__________") || !user.Tel.Equals(null))
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
            if (!user.Description.Equals("") || !user.Description.Equals(null))
            {
                cmd.Parameters.AddWithValue("@description", user.Description);
            }
            if (!user.Image.Equals(null))
            {
                cmd.Parameters.AddWithValue("@image", user.Image);
            }

            // prepare and execute
            cmd.Prepare();
            int rowsAffected = cmd.ExecuteNonQuery();

			int lastInsertedUserId = -1;
			// if rowsAffected equals to 1, then the insertion completed successfully
			if (rowsAffected == 1)
			{
				lastInsertedUserId = (int)cmd.LastInsertedId;
				Console.WriteLine(lastInsertedUserId);
			}
			
            return lastInsertedUserId; 
        }

		public static int Insert(Account account)
		{
			// query string
			string insertAccount = "INSERT INTO " +
				"Account (account_id, account_username, account_salted_password_hash, account_password_salt, account_email, account_created_at) " +
				"VALUES(@id, @username, @saltedPasswordHash, @passwordSalt, @email, @createdAt) ";

			MySqlCommand cmd = new MySqlCommand(insertAccount, connection);
			cmd.CommandTimeout = 500000;

			// add values to the parameters
			cmd.Parameters.AddWithValue("@id", account.User.Id);
			cmd.Parameters.AddWithValue("@username", account.Username);
			cmd.Parameters.AddWithValue("@saltedPasswordHash", account.SaltedPasswordHash);
			cmd.Parameters.AddWithValue("@passwordSalt", account.PasswordSalt);
			cmd.Parameters.AddWithValue("@email", account.Email);
			cmd.Parameters.AddWithValue("@createdAt", account.CreatedAt.Date);

			// prepare and execute
			cmd.Prepare();
			int rowsAffected = cmd.ExecuteNonQuery();

			return rowsAffected; // if rowsAffected equals to 1, then the insertion completed successfully
		}

		//delete

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

		public void Delete(Account account)
		{
			//code to Delete new account
		}

		//update

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

		public void Update(Account account)
		{
			//code to Update new account
		}
	}

    
}
