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
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DBConnect()
        {
            Initialize();
        }

        private void Initialize()
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
        private bool OpenConnection()
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
        private bool CloseConnection()
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

        public Byte[] GetLemmaBodyByTitle(string lemmaTitle)
        {
            Byte[] lemmaBody = new byte[10000];
            string query = "SELECT lemma_body FROM Lemma WHERE lemma_title = '" + lemmaTitle + "'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                lemmaBody = Encoding.UTF8.GetBytes(dataReader.GetString("lemma_body"));
            }

            return lemmaBody;
        }

        //insert

        public void Insert(Account account)
        {
            //code to insert new account
        }

        public void Insert(Category category)
        {
            //code to insert new category
        }

        public void Insert(Contact contact)
        {
            //code to insert new contact
        }

        public void Insert(ContactGroup contactGroup)
        {
            //code to insert contactgroup
        }

        public void Insert(EditedLemma editedLemma)
        {
            //code to insert editedLemma
        }

        public void Insert(EducationLevel educationLevel)
        {
            //code to insert educationLevel
        }

        public void Insert(FavoriteLemma favoriteLemma)
        {
            //code to insert favoriteLemma
        }

        public void Insert(Lemma lemma)
        {
            //code to insert lemma
        }

        public void Insert(Role role)
        {
            //code to insert role
        }

        public void Insert(SharedLemma sharedLemma)
        {
            //code to insert sharedLemma
        }

        public void Insert(User user)
        {
            //code to insert user
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
