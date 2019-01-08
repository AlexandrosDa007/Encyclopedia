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


        public static bool Initialize()
        {
            connection = new MySqlConnection(Encyclopedia.Properties.Settings.Default.Connection);
            return OpenConnection();
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

        public static bool LoginValidation(String username, String password)
        {
            string query = "SELECT account_username,account_salted_password_hash FROM Account WHERE account_username= @username AND account_salted_password_hash= @pass";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@pass", password);
            cmd.Prepare();
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

        
        #region Select Statements

        public static Byte[] GetLemmaBodyByTitle(string lemmaTitle)
        {
            byte[] lemmaBody = null;
            string query = "SELECT lemma_body FROM Lemma WHERE lemma_title = @title";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@title", lemmaTitle);
            cmd.Prepare();

            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                lemmaBody = (byte[])dataReader.GetValue(0);
            }

            dataReader.Close();
            return Compression.DecompressLemmas(lemmaBody);
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
                Lemma lemma = new Lemma(dataReader[0].ToString(), (byte[])dataReader["lemma_body"], Convert.ToInt32(dataReader[2].ToString()));
                lemmaList.Add(lemma);
                i++;
            }
            dataReader.Close();
            return lemmaList;
        }

        public static List<Lemma> GetFirstLemmas()
        {
            List<Lemma> lemmaList = new List<Lemma>();

            string query = "SELECT * FROM Lemma ORDER BY lemma_title LIMIT 500";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandTimeout = 500000;
            MySqlDataReader dataReader = cmd.ExecuteReader();
            int i = 0;
            while (dataReader.Read())
            {
                Console.WriteLine(i);
                Lemma lemma = new Lemma(dataReader[0].ToString(), (byte[])dataReader["lemma_body"], Convert.ToInt32(dataReader[2].ToString()));
                lemmaList.Add(lemma);
                i++;
            }
            dataReader.Close();
            return lemmaList;
        }

        public static List<string> GetLemmaTitleByCategoryName(string categoryName)
        {
            string query = "SELECT category_id FROM Category WHERE category_name = @cat";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@cat", categoryName);
            cmd.Prepare();
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

            query = "SELECT lemma_title FROM Lemma L JOIN Category C ON L.category_id = C.category_id WHERE C.category_id = @id";
            cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", category.Id);
            cmd.Prepare();
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
				string query = "SELECT category_id from Category WHERE category_name = @name";
				MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Prepare();
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
                EducationLevel educationLevel = new EducationLevel(dataReader.GetInt32("education_level_id"), dataReader.GetString("education_level_name"));
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
				educationLevelList.Add(dataReader.GetString("education_level_name"));
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
                Role role = new Role(dataReader.GetInt32("role_id"), dataReader.GetString("role_name"));
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
				roleList.Add(dataReader.GetString("role_name"));
			}

			string[] roleArray = roleList.ToArray();
			dataReader.Close();
			return roleArray;
		}

		public static string[] GetCategories()
		{
			List<string> categoryList = new List<string>();
			// construct query
			string selectQuery = "SELECT category_name FROM Category";
			MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
			cmd.CommandTimeout = 500000;

			// prepare and execute
			cmd.Prepare();
			MySqlDataReader dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				categoryList.Add(dataReader.GetString("category_name").Replace("_", " "));
			}

			string[] categoryArray = categoryList.ToArray();
			dataReader.Close();
			return categoryArray;
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

		public static List<User> GetContacts(int userId)
		{
			List<int> contactIdsList = new List<int>();

			// construct query
			string selectId = "SELECT contact_id FROM Contact WHERE user_id = @user";
			MySqlCommand select = new MySqlCommand(selectId, connection);
			select.Parameters.AddWithValue("@user", userId);
			select.CommandTimeout = 500000;

			// prepare and execute
			select.Prepare();
			MySqlDataReader dataReader = select.ExecuteReader();

			while (dataReader.Read())
			{
				// store the contact ids
				contactIdsList.Add(dataReader.GetInt32("contact_id"));
			}
			dataReader.Close();

			List<User> contactList = new List<User>();

			foreach (int contactId in contactIdsList)
			{
				// get the contacts from their account ids
				User contact = GetUserByAccountId(contactId);
				contactList.Add(contact);
			}

			return contactList;
		}

		public static List<ContactGroup> GetContactGroups(int userId)
		{
			List<ContactGroup> groupList = new List<ContactGroup>();

			// get user
			User user = GetUserByAccountId(userId);
			
			// construct query
			string selectId = "SELECT * FROM Contact_Group WHERE owner_id = @user";
			MySqlCommand select = new MySqlCommand(selectId, connection);
			select.Parameters.AddWithValue("@user", userId);
			select.CommandTimeout = 500000;

			// prepare and execute
			select.Prepare();
			MySqlDataReader dataReader = select.ExecuteReader();

			while (dataReader.Read())
			{
				// add the groups
				ContactGroup group = new ContactGroup(dataReader.GetInt32("group_id"), dataReader.GetString("group_name"), user);
				groupList.Add(group);
			}

			dataReader.Close();
			return groupList;
		}

		public static List<int> GetContactGroupMembers(ContactGroup group)
		{
			List<int> groupMembersList = new List<int>();
			
			// construct query
			string selectId = "SELECT contact_id FROM Contact WHERE group_id = @group";
			MySqlCommand select = new MySqlCommand(selectId, connection);
			select.Parameters.AddWithValue("@group", group.Id);
			select.CommandTimeout = 500000;

			// prepare and execute
			select.Prepare();
			MySqlDataReader dataReader = select.ExecuteReader();

			while (dataReader.Read())
			{
				// add the group members
				groupMembersList.Add(dataReader.GetInt32("contact_id"));
			}

			dataReader.Close();
			return groupMembersList;
		}

		public static List<Account> GetSearchMatchingAccounts(string searchString)
		{
			List<Account> matchingAccountsList = new List<Account>();

			// adjust search pattern
			string searchPattern = "%" + searchString + "%";

			// construct query
			string selectId = "SELECT user_id, user_name, user_surname, account_username, account_email " +
				"FROM User INNER JOIN Account on user_id = account_id " +
				"WHERE user_name LIKE @searchPattern OR user_surname LIKE @searchPattern OR account_username LIKE @searchPattern OR account_email LIKE @searchPattern " +
				"ORDER BY user_name, user_surname";
			MySqlCommand select = new MySqlCommand(selectId, connection);
			select.Parameters.AddWithValue("@searchPattern", searchPattern);
			select.CommandTimeout = 500000;

			// prepare and execute
			select.Prepare();
			MySqlDataReader dataReader = select.ExecuteReader();

			// add the matching user accounts
			while (dataReader.Read())
			{
				// configure the matching user's details
				User user = new User();
				user.Id = dataReader.GetInt32("user_id");
				user.Name = dataReader.GetString("user_name");
				user.Surname = dataReader.GetString("user_surname");

				// configure the matching account's details
				Account account = new Account();
				account.User = user;
				account.Username = dataReader.GetString("account_username");
				account.Email = dataReader.GetString("account_email");

				matchingAccountsList.Add(account);
			}

			dataReader.Close();
			return matchingAccountsList;
		}

		public static List<string> GetPopularLemmata()
		{
			List<string> popularLemmataList = new List<string>();

			// construct query
			string query = "SELECT count(*) AS popularity, lemma_title FROM Favorite_Lemma " +
				"GROUP BY lemma_title ORDER BY popularity DESC LIMIT 10";
			MySqlCommand cmd = new MySqlCommand(query, connection);
			cmd.CommandTimeout = 500000;

			// prepare and execute
			cmd.Prepare();
			MySqlDataReader dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				// add the lemma titles
				popularLemmataList.Add(dataReader.GetString("lemma_title"));
			}

			dataReader.Close();
			return popularLemmataList;
		}

		public static int GetLemmaCategoryByTitle(string lemmaTitle)
        {
            int lemmaCategory=-1;
            string query = "SELECT category_id FROM Lemma WHERE lemma_title = @title";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@title", lemmaTitle);
            cmd.Prepare();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                lemmaCategory = dataReader.GetInt32("category_id");
            }

            dataReader.Close();
            return lemmaCategory;
        }

        public static string GetUserNameByID(int userID)
        {
            string userName = "";
            string query = "SELECT user_name FROM User WHERE user_id='" + userID +"'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                userName = dataReader.GetString("user_name");
            }

            dataReader.Close();
            return userName;
        }

        public static string GetUserSurnameByID(int userID)
        {
            string userSurname = "";
            string query = "SELECT user_surname FROM User WHERE user_id='" + userID + "'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                userSurname = dataReader.GetString("user_surname");
            }

            dataReader.Close();
            return userSurname;
        }

        public static DateTime GetUserDateOfBirthByID(int userID)
        {
            DateTime userDateOfBirth = new DateTime();
            string query = "SELECT user_date_of_birth FROM User WHERE user_id='" + userID + "'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                userDateOfBirth = dataReader.GetDateTime("user_date_of_birth");
            }

            dataReader.Close();
            return userDateOfBirth;
        }

        public static Lemma GetRandomLemma()
        {
			Lemma lemma = null;

            string query = "SELECT * FROM Lemma ORDER BY RAND() LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                lemma = new Lemma(dataReader.GetString("lemma_title"), Compression.DecompressLemmas((byte[])dataReader.GetValue(1)), dataReader.GetInt32("category_id"));
            }

            dataReader.Close();
            return lemma;
        }
		
        public static string GetSaltByUsername(string username)
        {
            string salt = "";
            string selectQuery = "SELECT account_password_salt FROM Account WHERE account_username = @user";
            MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
            cmd.CommandTimeout = 500000;
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Prepare();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                salt = dataReader[0].ToString();
            }
            dataReader.Close();

            return salt;
        }

        public static Account GetAccountByUsername(string username)
        {
            Account account;
            string selectQuery = "SELECT account_id,account_salted_password_hash,account_password_salt,account_email,account_created_at FROM Account WHERE account_username = @user";
            MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
            cmd.CommandTimeout = 500000;
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Prepare();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            int accountId = -999;
            string accountPassword = "";
            string accountSalt = "";
            string accountEmail = "";
            DateTime accountCreatedAt = new DateTime();

            while (dataReader.Read())
            {
                accountId = Convert.ToInt32(dataReader[0].ToString());
                accountPassword = dataReader[1].ToString();
                accountSalt = dataReader[2].ToString();
                accountEmail = dataReader[3].ToString();
                accountCreatedAt = DateTime.Parse(dataReader[4].ToString());
            }

            dataReader.Close();
            account = new Account(GetUserByAccountId(accountId),username,accountPassword,accountSalt,accountEmail,accountCreatedAt);

            return account;
        }

        public static User GetUserByAccountId(int accountId)
        {
            User user;
            string selectQuery = "SELECT user_name,user_surname,user_date_of_birth,user_gender,user_tel,user_role_id,"+
                "user_education_level_id,user_description,user_image FROM User WHERE user_id = @id";
            MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
            cmd.CommandTimeout = 500000;
            cmd.Parameters.AddWithValue("@id", accountId);
            cmd.Prepare();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            string userName = "";
            string userSurname = "";
            DateTime dateOfBirth = new DateTime();
            char gender = '-';
            string telNumber = "";
            int userRoleId = -999;
            int userEducationLevelId = -999;
            string userDescription = "";
            byte[] userImage = null;

            while (dataReader.Read())
            {
                userName = dataReader[0].ToString();
                userSurname = dataReader[1].ToString();
                dateOfBirth = DateTime.Parse(dataReader[2].ToString());
                if (!dataReader.IsDBNull(3))
                    gender = Char.Parse(dataReader["user_gender"].ToString());
                if (!dataReader.IsDBNull(4))
                    telNumber = dataReader[4].ToString();
                if (!dataReader.IsDBNull(5))
                    userRoleId = Convert.ToInt32(dataReader[5].ToString());
                if (!dataReader.IsDBNull(6))
                    userEducationLevelId = Convert.ToInt32(dataReader[6].ToString());
                if (!dataReader.IsDBNull(7))
                    userDescription = dataReader[7].ToString();
                if(!dataReader.IsDBNull(8))
                    userImage = (byte[])dataReader["user_image"];
            }
            dataReader.Close();
            Role role = GetRoleById(userRoleId);
            EducationLevel educationLevel = GetEducationLevelById(userEducationLevelId);

            user = new User(accountId,userName,userSurname,dateOfBirth,gender,telNumber,role,educationLevel,userDescription,userImage);

            return user;
        }

        public static Role GetRoleById(int roleId)
        {
            Role role;
            string selectQuery = "SELECT role_name FROM Role WHERE role_id = @id";
            MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
            cmd.CommandTimeout = 500000;
            cmd.Parameters.AddWithValue("@id", roleId);
            cmd.Prepare();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            string roleName = "";

            while (dataReader.Read())
            {
                roleName = dataReader[0].ToString();
            }

            dataReader.Close();

            role = new Role(roleId, roleName);

            return role;
        }

        public static EducationLevel GetEducationLevelById(int educationLevelId)
        {
            EducationLevel educationLevel;
            string selectQuery = "SELECT education_level_name FROM Education_Level WHERE education_level_id = @id";
            MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
            cmd.CommandTimeout = 500000;
            cmd.Parameters.AddWithValue("@id", educationLevelId);
            cmd.Prepare();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            string educationLevelName = "";

            while (dataReader.Read())
            {
                educationLevelName = dataReader[0].ToString();
            }

            dataReader.Close();

            educationLevel = new EducationLevel(educationLevelId, educationLevelName);

            return educationLevel;
        }

        public static List<EditedLemma> GetEditedLemmasByUser(User user)
        {
            List<EditedLemma> list = new List<EditedLemma>();
            string selectQuery = "SELECT lemma_title ,edited_lemma_created_at from Edited_Lemma where editor_id = @id";
            MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
            cmd.CommandTimeout = 500000;
            cmd.Parameters.AddWithValue("@id", user.Id);
            cmd.Prepare();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            string lemmaTitle = "";
            DateTime createdAt = new DateTime();
            
            while (dataReader.Read())
            {
                lemmaTitle = dataReader.GetString("lemma_title");
                createdAt = dataReader.GetDateTime("edited_lemma_created_at");
                EditedLemma editedLemma = new EditedLemma(lemmaTitle, user, null, createdAt, DateTime.Now);
                list.Add(editedLemma);
            }
            dataReader.Close();

            return list;
        }

        public static EditedLemma GetEditedLemmaByUserAndTitle(string lemmaTitle, User user)
        {
            EditedLemma editedLemma;
            string selectQuery = "SELECT edited_lemma_body,edited_lemma_created_at,edited_lemma_updated_at FROM Edited_Lemma WHERE editor_id = @id AND lemma_title = @title";
            MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
            cmd.CommandTimeout = 500000;
            cmd.Parameters.AddWithValue("@id", user.Id);
            cmd.Parameters.AddWithValue("@title", lemmaTitle);
            cmd.Prepare();

            byte[] body = null;
            DateTime createdAt = new DateTime();
            DateTime updatedAt = new DateTime();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                body = Encoding.UTF8.GetBytes(dataReader.GetString("edited_lemma_body"));
                createdAt = dataReader.GetDateTime("edited_lemma_created_at");
                updatedAt = dataReader.GetDateTime("edited_lemma_updated_at");
            }
            dataReader.Close();
            

            editedLemma = new EditedLemma(lemmaTitle, user, body, createdAt, updatedAt);
            Console.WriteLine(editedLemma.LemmaTitle);
            return editedLemma;
        }

        public static List<FavoriteLemma> GetFavoriteLemmasByUser(User user)
        {
            List<FavoriteLemma> list = new List<FavoriteLemma>();
            string selectQuery = "SELECT lemma_title,favorite_lemma_created_at FROM Favorite_Lemma WHERE user_id = @id";
            MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
            cmd.CommandTimeout = 500000;
            cmd.Parameters.AddWithValue("@id", user.Id);
            cmd.Prepare();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            string lemmaTitle = "";
            DateTime createdAt = new DateTime();
            while (dataReader.Read())
            {
                lemmaTitle = dataReader.GetString("lemma_title");
                createdAt = dataReader.GetDateTime("favorite_lemma_created_at");
                FavoriteLemma editedLemma = new FavoriteLemma(lemmaTitle,user,createdAt);
                list.Add(editedLemma);
            }
            dataReader.Close();

            return list;
        }

        public static Account GetAccountByUser(User user)
        {
            Account account = new Account();
            string selectQuery = "SELECT account_username, account_email FROM Account WHERE account_id = @id";
            MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
            cmd.CommandTimeout = 500000;
            cmd.Parameters.AddWithValue("@id", user.Id);
            cmd.Prepare();
            MySqlDataReader dataReader = cmd.ExecuteReader();


            while (dataReader.Read())
            {
                account.User = user;
                account.Email = dataReader.GetString("account_email");
                account.Username = dataReader.GetString("account_username");
            }
            dataReader.Close();

            return account;
        }

       public static Account GetAccountByEmail(string email)
        {
            Account account = new Account();
            string selectQuery = "SELECT account_username FROM Account WHERE account_email = @email";
            MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
            cmd.CommandTimeout = 500000;
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Prepare();

            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                account.Email = email;
                account.Username = dataReader.GetString("account_username");
            }
            dataReader.Close();

            return account;

        }

        public static User GetUserByAccountUsername(string username)
        {

            User user = new User();
            string selectQuery = "SELECT "+"user_id,user_name,user_surname,user_date_of_birth,user_gender,user_tel,"+
                "user_role_id,user_education_level_id,user_description,user_image"+
                " FROM User U JOIN Account A ON U.user_id = A.account_id WHERE A.account_username = @username";
            MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
            cmd.CommandTimeout = 500000;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Prepare();

            MySqlDataReader dataReader = cmd.ExecuteReader();

            string desc = "";
            while (dataReader.Read())
            {
                user.Id = dataReader.GetInt32("user_id");
                user.Name = dataReader.GetString("user_name");
                user.Surname = dataReader.GetString("user_surname");
                user.DateOfBirth = dataReader.GetDateTime("user_date_of_birth");
                if (dataReader.IsDBNull(4))
                    user.Gender = '-';
                else
                    user.Gender = dataReader.GetChar("user_gender");
                if (dataReader.IsDBNull(5))
                    user.Tel = "";
                else
                    user.Tel = dataReader.GetString("user_tel");
                if (dataReader.IsDBNull(6))
                    user.Role = new Role(-999, "");
                else
                    user.Role = new Role(dataReader.GetInt32("user_role_id"),"");
                if (dataReader.IsDBNull(7))
                    user.EducationLevel = new EducationLevel(-999, "");
                else
                    user.EducationLevel = new EducationLevel(dataReader.GetInt32("user_education_level_id"),"");
                if (!dataReader.IsDBNull(8))
                   desc = dataReader.GetString("user_description");

                if (dataReader.IsDBNull(9))
                    user.Image = null;
                else
                    user.Image = (byte[])dataReader["user_image"];
            }
            dataReader.Close();
            user.Description = desc;
            if (user.EducationLevel.Id != -999)
                user.EducationLevel = DBConnect.GetEducationLevelById(user.EducationLevel.Id);
            if (user.Role.Id != -999)
                user.Role = DBConnect.GetRoleById(user.Role.Id);

            return user;
        }


        #endregion

        #region Insert Statements

        public static int Insert(Category category)
        {
            string categoryName = category.Name;
            
            //Create prepared statement string
            string insertCategory = "INSERT INTO " +
                "Category (category_name ) " +
                "VALUES(@categoryName) ";

            MySqlCommand cmd = new MySqlCommand(insertCategory, connection);
            cmd.CommandTimeout = 500000;
            // add values to the parameters
            cmd.Parameters.AddWithValue("@categoryName", categoryName);

            // prepare and execute
            cmd.Prepare();
            int rowsAffected = cmd.ExecuteNonQuery();

            return rowsAffected; // if rowsAffected equals to 1, then the insertion completed successfully
        }

        public static int Insert(Contact contact)
        {
            User user = contact.User;
            User contactUser = contact.ContactUser;
            ContactGroup contactGroup = null;
            if(contact.ContactGroup!=null)
                contactGroup = contact.ContactGroup;

            int userID = user.Id;
            int contactID = contactUser.Id;
            int groupID = -999;
            if(contact.ContactGroup!=null)
                groupID = contactGroup.Id;


            //Create prepared statement string
            string insertContact = "INSERT INTO " +
                "Contact (user_id ,contact_id ,group_id  ) " +
                "VALUES(@userID,@contactID,@groupID) ";

            MySqlCommand cmd = new MySqlCommand(insertContact, connection);
            cmd.CommandTimeout = 500000;
            // add values to the parameters
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@contactID", contactID);
            if (groupID != -999)
                cmd.Parameters.AddWithValue("@groupID", groupID);
            else
                cmd.Parameters.AddWithValue("@groupID", DBNull.Value);

            // prepare and execute
            cmd.Prepare();
            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected; // if rowsAffected equals to 1, then the insertion completed successfully
        }

        public static int Insert(ContactGroup contactGroup)
        {
            string contactGroupName = contactGroup.Name;
            User owner = contactGroup.Owner;

            int ownerID = owner.Id;

            //Create prepared statement string
            string insertContactGroup = "INSERT INTO " +
                "Contact_Group (group_name,owner_id) " +
                "VALUES(@contactGroupName,@ownerID) ";

            MySqlCommand cmd = new MySqlCommand(insertContactGroup, connection);
            cmd.CommandTimeout = 500000;
            // add values to the parameters
            cmd.Parameters.AddWithValue("@contactGroupName", contactGroupName);
            cmd.Parameters.AddWithValue("@ownerID", ownerID);

            // prepare and execute
            cmd.Prepare();
            int rowsAffected = cmd.ExecuteNonQuery();

            return rowsAffected; // if rowsAffected equals to 1, then the insertion completed successfully
        }

        public static int Insert(EditedLemma editedLemma)
        {
            string lemmaTitle = editedLemma.LemmaTitle;
            User editor = editedLemma.Editor;
            string editedBody = editedLemma.Body;
            DateTime createdAt = editedLemma.CreatedAt;
            DateTime updatedAt = editedLemma.UpdatedAt;

            int editorID = editor.Id;


            //Create prepared statement string
            string insertEditedLemma = "INSERT INTO " +
                "Edited_Lemma (lemma_title,editor_id ,edited_lemma_body ,edited_lemma_created_at ,edited_lemma_updated_at ) " +
                "VALUES(@lemmaTitle,@editorID,@editedBody,@createdAt,@updatedAt) ";

            MySqlCommand cmd = new MySqlCommand(insertEditedLemma, connection);
            cmd.CommandTimeout = 500000;
            // add values to the parameters
            cmd.Parameters.AddWithValue("@lemmaTitle", lemmaTitle);
            cmd.Parameters.AddWithValue("@editorID", editorID);
            cmd.Parameters.AddWithValue("@editedBody", editedBody);
            cmd.Parameters.AddWithValue("@createdAt", createdAt);
            cmd.Parameters.AddWithValue("@updatedAt", updatedAt);

            // prepare and execute
            cmd.Prepare();
            int rowsAffected = cmd.ExecuteNonQuery();

            return rowsAffected; // if rowsAffected equals to 1, then the insertion completed successfully
        }

        public static int Insert(EducationLevel educationLevel)
        {
            string educationLevelName = educationLevel.Name;

            //Create prepared statement string
            string insertEducationLevel = "INSERT INTO " +
                "Education_Level (education_level_name ) " +
                "VALUES(@educationLevelName) ";

            MySqlCommand cmd = new MySqlCommand(insertEducationLevel, connection);
            cmd.CommandTimeout = 500000;
            // add values to the parameters
            cmd.Parameters.AddWithValue("@educationLevelName", educationLevelName);

            // prepare and execute
            cmd.Prepare();
            int rowsAffected = cmd.ExecuteNonQuery();

            return rowsAffected; // if rowsAffected equals to 1, then the insertion completed successfully
        }

        public static int Insert(FavoriteLemma favoriteLemma)
        {
            //Get object properties into local variables
            User user = favoriteLemma.User;
            DateTime createdAt = favoriteLemma.CreatedAt;

            string lemmaTitle = favoriteLemma.Title;
            int userID = user.Id;

            //Create prepared statement string
            string insertFavoriteLemma = "INSERT INTO " +
                "Favorite_Lemma (lemma_title,user_id,favorite_lemma_created_at) " +
                "VALUES(@title, @userID, @createdAt) ";

            MySqlCommand cmd = new MySqlCommand(insertFavoriteLemma, connection);
            cmd.CommandTimeout = 500000;
            // add values to the parameters
            cmd.Parameters.AddWithValue("@title", lemmaTitle);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@createdAt", createdAt);

            // prepare and execute
            cmd.Prepare();
            int rowsAffected = cmd.ExecuteNonQuery();

            return rowsAffected; // if rowsAffected equals to 1, then the insertion completed successfully
        }

        public static int Insert(Lemma lemma)
        {
            string lemmaTitle = lemma.Title;
            byte[] lemmaBody = Compression.CompressLemmas(lemma.Body);
            int categoryID = lemma.Category;


            //Create prepared statement string
            string insertLemma = "INSERT INTO " +
                "Lemma (lemma_title,lemma_body,category_id) " +
                "VALUES(@lemmaTitle,@lemmaBody,@categoryID) ";

            MySqlCommand cmd = new MySqlCommand(insertLemma, connection);
            cmd.CommandTimeout = 500000;
            // add values to the parameters
            cmd.Parameters.AddWithValue("@lemmaTitle", lemmaTitle);
            cmd.Parameters.AddWithValue("@lemmaBody", lemmaBody);
            cmd.Parameters.AddWithValue("@categoryID", categoryID);

            // prepare and execute
            cmd.Prepare();
            int rowsAffected = cmd.ExecuteNonQuery();

            return rowsAffected; // if rowsAffected equals to 1, then the insertion completed successfully
        }

        public static int Insert(Role role)
        {
            string roleName = role.Name;

            //Create prepared statement string
            string insertRole = "INSERT INTO " +
                "Role (role_name) " +
                "VALUES(@roleName) ";

            MySqlCommand cmd = new MySqlCommand(insertRole, connection);
            cmd.CommandTimeout = 500000;
            // add values to the parameters
            cmd.Parameters.AddWithValue("@roleName", roleName);

            // prepare and execute
            cmd.Prepare();
            int rowsAffected = cmd.ExecuteNonQuery();

            return rowsAffected; // if rowsAffected equals to 1, then the insertion completed successfully
        }

        public static int Insert(SharedLemma sharedLemma)
        {
            //Get object properties into local variables
            Lemma lemma = sharedLemma.Lemma;
            User sender = sharedLemma.Sender;
            User receiver = sharedLemma.Receiver;
            DateTime sendingDate = sharedLemma.SendingDate;
            Boolean ifEditedLemma = sharedLemma.IfEditedLemma;
            string additionalNotes = sharedLemma.AdditionalNotes;

            string lemmaTitle = lemma.Title;
            int senderID = sender.Id;
            int receiverID = receiver.Id;

            //Create prepared statement string
            string insertSharedLemma = "INSERT INTO " +
                "Shared_Lemma (sender_id,receiver_id,lemma_title,if_edited_lemma,sending_date,additional_notes ) " +
                "VALUES(@senderID, @receiverID, @lemmaTitle,@ifEditedLemma,@sendingDate,@additionalNotes) ";

            MySqlCommand cmd = new MySqlCommand(insertSharedLemma, connection);
            cmd.CommandTimeout = 500000;
            // add values to the parameters
            cmd.Parameters.AddWithValue("@senderID", senderID);
            cmd.Parameters.AddWithValue("@receiverID", receiverID);
            cmd.Parameters.AddWithValue("@lemmaTitle", lemmaTitle);
            cmd.Parameters.AddWithValue("@ifEditedLemma", ifEditedLemma);
            cmd.Parameters.AddWithValue("@sendingDate", sendingDate);
            cmd.Parameters.AddWithValue("@additionalNotes", additionalNotes);

            // prepare and execute
            cmd.Prepare();
            int rowsAffected = cmd.ExecuteNonQuery();

            return rowsAffected; // if rowsAffected equals to 1, then the insertion completed successfully
        }

		public static int Insert(User user, Account account)
		{
			int userId = Insert(user);
			// if the userId remained -1, it means that the insertion was unsuccessful
			if (userId != -1)
			{
				account.User.Id = userId;

				// if rowsAffectedAccount equals to 1, then the insertion completed successfully
				int rowsAffectedAccount = Insert(account);
				if (rowsAffectedAccount != 1)
				{
					return 3;
				}
			}
			else
			{
				return 2;
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
            if (!user.Gender.Equals('-'))
            {
                insertFields += ", user_gender";
                insertValues += ", @gender";
            }
            if (!user.Tel.Equals("__________"))
			{
                insertFields += ", user_tel";
                insertValues += ", @tel";
            }
            if (user.Role != null)
            {
                insertFields += ", user_role_id";
                insertValues += ", @roleId";
            }
            if (user.EducationLevel != null)
            {
                insertFields += ", user_education_level_id";
                insertValues += ", @educationLevelId";
            }
            if (!user.Description.Length.Equals(0))
			{
                insertFields += ", user_description";
                insertValues += ", @description";
            }
            if (user.Image != null)
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
            cmd.Parameters.AddWithValue("@dateOfBirth", user.DateOfBirth.Date);
            if (!user.Gender.Equals('-'))
			{
                cmd.Parameters.AddWithValue("@gender", user.Gender);
            }
            if (!user.Tel.Equals("__________"))
			{
                cmd.Parameters.AddWithValue("@tel", user.Tel);
            }
            if (user.Role != null)
            {
                cmd.Parameters.AddWithValue("@roleId", user.Role.Id);
            }
            if (user.EducationLevel != null)
            {
                cmd.Parameters.AddWithValue("@educationLevelId", user.EducationLevel.Id);
            }
            if (!user.Description.Length.Equals(0))
            {
                cmd.Parameters.AddWithValue("@description", user.Description);
            }
            if (user.Image != null)
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

        #endregion

        #region Delete Statements

        public static void Delete(Category category)
        {
            //code to Delete new category
        }

        public static int Delete(Contact contact)
        {
            string query = "DELETE FROM Contact WHERE user_id = @userId AND contact_id = @contId";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@userId", contact.User.Id);
            cmd.Parameters.AddWithValue("@contId", contact.ContactUser.Id);
            cmd.Prepare();
            cmd.CommandTimeout = 500000;

            int rowsAffected = cmd.ExecuteNonQuery();


            return rowsAffected;
        }

        public static void Delete(ContactGroup contactGroup)
        {
            //code to Delete contactgroup
        }

        public static int Delete(EditedLemma editedLemma, User user)
        {
            string query = "DELETE FROM Edited_Lemma WHERE editor_id = @id AND lemma_title = @title";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", user.Id);
            cmd.Parameters.AddWithValue("@title", editedLemma.LemmaTitle);
            cmd.Prepare();
            cmd.CommandTimeout = 500000;

            int rowsAffected = cmd.ExecuteNonQuery();


            return rowsAffected;
        }

        public static void Delete(EducationLevel educationLevel)
        {
            //code to Delete educationLevel
        }

        public static int Delete(FavoriteLemma favoriteLemma, User user)
        {
            string query = "DELETE FROM Favorite_Lemma WHERE user_id = @id AND lemma_title = @title";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", user.Id);
            cmd.Parameters.AddWithValue("@title", favoriteLemma.Title);
            cmd.Prepare();
            cmd.CommandTimeout = 500000;

            int rowsAffected = cmd.ExecuteNonQuery();


            return rowsAffected;
        }

        public static void Delete(Lemma lemma)
        {
            //code to Delete lemma
        }

        public static void Delete(Role role)
        {
            //code to Delete role
        }

        public static void Delete(SharedLemma sharedLemma)
        {
            //code to Delete sharedLemma
        }

        public static void Delete(User user)
        {
			//code to Delete user
		}

		public static void Delete(Account account)
		{
			//code to Delete new account
		}
        #endregion

        #region Update Statements

        public static void Update(Category category)
        {
            //code to Update new category
        }

        public static void Update(Contact contact)
        {
            //code to Update new contact
        }

        public static void Update(ContactGroup contactGroup)
        {
            //code to Update contactgroup
        }

        public static int Update(EditedLemma editedLemma, User user)
        {
            string query = "UPDATE Edited_Lemma SET edited_lemma_body = @body" +
                ",edited_lemma_updated_at = @update WHERE lemma_title = @title AND  editor_id = @id";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandTimeout = 500000;
            cmd.Parameters.AddWithValue("@body", Encoding.UTF8.GetBytes(editedLemma.Body));
            cmd.Parameters.AddWithValue("@update", editedLemma.UpdatedAt);
            cmd.Parameters.AddWithValue("@title", editedLemma.LemmaTitle);
            cmd.Parameters.AddWithValue("@id", user.Id);
            cmd.Prepare();

            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected;
        }

        public static void Update(EducationLevel educationLevel)
        {
            //code to Update educationLevel
        }

        public static void Update(FavoriteLemma favoriteLemma)
        {
            //code to Update favoriteLemma
        }

        public static int Update(string title, byte[]body)
        {
            string query = "UPDATE Lemma SET lemma_body = @body WHERE lemma_title = @title";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandTimeout = 500000;
            cmd.Parameters.AddWithValue("@body", body);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Prepare();

            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected;
        }

        public static void Update(Role role)
        {
            //code to Update role
        }

        public static void Update(SharedLemma sharedLemma)
        {
            //code to Update sharedLemma
        }

        public static int Update(User user)
        {
            string query = "UPDATE User SET user_name = @name, user_surname = @surname, user_date_of_birth "+
                "= @date,user_gender = @gender, user_tel = @tel, user_role_id = @role, user_education_level_id = @edu,"+
                " user_description = @description, user_image = @img WHERE user_id = @id";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandTimeout = 500000;
            cmd.Parameters.AddWithValue("@name", user.Name);
            cmd.Parameters.AddWithValue("@surname", user.Surname);
            cmd.Parameters.AddWithValue("@date", user.DateOfBirth);
            if(user.Gender.Equals('-'))
                cmd.Parameters.AddWithValue("@gender", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@gender", user.Gender);

            if(user.Tel.Equals("") || user.Tel == null || user.Tel.Equals("__________"))
                cmd.Parameters.AddWithValue("@tel", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@tel", user.Tel);
            if(user.Role.Id == -999)
                cmd.Parameters.AddWithValue("@role", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@role", user.Role.Id);
            if(user.EducationLevel.Id == -999)
                cmd.Parameters.AddWithValue("@edu", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@edu", user.EducationLevel.Id);
            if(user.Description == null || user.Description.Equals(""))
                cmd.Parameters.AddWithValue("@description", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@description", user.Description);
            if(user.Image == null)
                cmd.Parameters.AddWithValue("@img", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@img", user.Image);

            cmd.Parameters.AddWithValue("@id", user.Id);
            cmd.Prepare();

            
            int rowsAffected = cmd.ExecuteNonQuery();


            return rowsAffected;
        }

		public static int CheckAccountMatchAndUpdate(string username, string email, string tempPassword)
		{
			Account account = new Account();

			// configure account details
			account.Username = username;
			account.Email = email;
			// create and set up password salt and salted password hash
			string salt = PasswordUtilities.CreateSalt(16);
			string passwordHashed = PasswordUtilities.GenerateSHA256Hash(tempPassword, salt);
			account.PasswordSalt = salt;
			account.SaltedPasswordHash = passwordHashed;

			// if rowsAffectedAccount equals to 1, then the update completed successfully
			int rowsAffectedAccount = Update(account);
			if (rowsAffectedAccount != 1)
			{
				return 3;
			}

			// if the method doesn't return 0, something went wrong with the database
			return 0;
		}

		public static int Update(Account account)
		{
            string query = "UPDATE Account SET account_salted_password_hash = @pass, account_password_salt = @salt WHERE account_username = @username AND account_email = @email";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.CommandTimeout = 500000;
            cmd.Parameters.AddWithValue("@salt", account.PasswordSalt);
			cmd.Parameters.AddWithValue("@pass", account.SaltedPasswordHash);
			cmd.Parameters.AddWithValue("@username", account.Username);
            cmd.Parameters.AddWithValue("@email", account.Email);
            cmd.Prepare();
            int rowsAffected = cmd.ExecuteNonQuery();
			
            return rowsAffected;
        }
	}
    #endregion

}