using Encyclopedia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encyclopedia.Controller
{
    class Favorite
    {
        public static void addToFavorites(int userID, string lemmaTitle)
        {
            //Get the properties needed for the creation of Lemma object
            byte[] lemmaBody = DBConnect.GetLemmaBodyByTitle(lemmaTitle);
            int lemmaCategory = DBConnect.GetLemmaCategoryByTitle(lemmaTitle);
            Lemma lemma = new Lemma(lemmaTitle, lemmaBody, lemmaCategory);

            //Get the properties needed for the creation of User object.
            string userName = DBConnect.GetUserNameByID(userID);
            string userSurname = DBConnect.GetUserSurnameByID(userID);
            DateTime dateOfBirth = DBConnect.GetUserDateOfBirthByID(userID);
            User user = new User(userID, userName, userSurname, dateOfBirth);

            DateTime createdAt = new DateTime();

            //Create a FavoriteLemma object with the above properties.
            FavoriteLemma fLemma = new FavoriteLemma(lemma,user, createdAt);

            //Insert the favorite lemma to DB.
            int result = DBConnect.Insert(fLemma);
            if (result == 1)//If  result=1 then everything is OK.
            {
                Console.WriteLine("Favorite lemma successfully added to the Database!");
            }
            else // If result!=1 then something went wrong.
            {
                Console.WriteLine("There was a problem inserting this Favorite lemma into Database.");
            }
        }
    }
}
