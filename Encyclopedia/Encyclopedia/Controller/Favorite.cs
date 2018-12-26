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
            byte[] lemmaBody = DBConnect.GetLemmaBodyByTitle(lemmaTitle);
            int lemmaCategory = DBConnect.GetLemmaCategoryByTitle(lemmaTitle);
            Lemma lemma = new Lemma(lemmaTitle, lemmaBody, lemmaCategory);

            string userName = DBConnect.GetUserNameByID(userID);
            string userSurname = DBConnect.GetUserSurnameByID(userID);
            DateTime dateOfBirth = DBConnect.GetUserDateOfBirthByID(userID);
            User user = new User(userID, userName, userSurname, dateOfBirth);

            DateTime createdAt = new DateTime();

            FavoriteLemma fLemma = new FavoriteLemma(lemma,user, createdAt);

            int result = DBConnect.Insert(fLemma);
        }
    }
}
