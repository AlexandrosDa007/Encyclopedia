using Encyclopedia.Model;
using Encyclopedia.View;
using System;
using System.Windows.Forms;

namespace Encyclopedia.Controller
{
	/// <summary>
	/// Contains function to add the specified lemma to the user's favorites.
	/// </summary>
	class Favorite
    {
        public static void addToFavorites(int userID, string lemmaTitle)
        {
            // Get the properties needed for the creation of Lemma object
            byte[] lemmaBody = DBConnect.GetLemmaBodyByTitle(lemmaTitle);
            int lemmaCategory = DBConnect.GetLemmaCategoryByTitle(lemmaTitle);
            Lemma lemma = new Lemma(lemmaTitle, lemmaBody, lemmaCategory);

            // Get the properties needed for the creation of User object.
            string userName = DBConnect.GetUserNameByID(userID);
            string userSurname = DBConnect.GetUserSurnameByID(userID);
            DateTime dateOfBirth = DBConnect.GetUserDateOfBirthByID(userID);
            User user = new User(userID, userName, userSurname, dateOfBirth);

            DateTime createdAt = DateTime.Now;

            // Create a FavoriteLemma object with the above properties.
            FavoriteLemma fLemma = new FavoriteLemma(lemma.Title,user, createdAt);

            // Insert the favorite lemma to DB.
            int result = DBConnect.Insert(fLemma);
            if (result == 1) // If result=1 then everything is OK.
            {
                FavouriteLemmataUserControl.Instance.FavoriteLemmas.Add(fLemma);
                FavouriteLemmataUserControl.Instance.SetLemmas();
            }
            else // If result!=1 then something went wrong.
            {
                MessageBox.Show("  The Lemma wasn't added to Favorites. Try again!");
            }
        }
    }
}
