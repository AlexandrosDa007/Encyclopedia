using Encyclopedia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encyclopedia.Controller
{
    class Message
    {
        //userID: the id of the current user logged in.
        //lemmaTitle: the lemma of  the title to be send.
        //receivers: array with the IDs of the receivers.
        //additional notes: a string with extra notes from the user.
        public static int sendMessage(int userID,string lemmaTitle,int[] receivers,string additionalNotes)
        {
            //Get the properties needed for the creation of Lemma object
            byte[] lemmaBody = DBConnect.GetLemmaBodyByTitle(lemmaTitle);
            int lemmaCategory = DBConnect.GetLemmaCategoryByTitle(lemmaTitle);
            Lemma lemma = new Lemma(lemmaTitle, lemmaBody, lemmaCategory);

            //Get the properties needed for the creation of User object.
            string userName = DBConnect.GetUserNameByID(userID);
            string userSurname = DBConnect.GetUserSurnameByID(userID);
            DateTime senderDateOfBirth = DBConnect.GetUserDateOfBirthByID(userID);
            User sender = new User(userID, userName, userSurname, senderDateOfBirth);

            DateTime sendingDate = new DateTime();

			int result = 0;
            for (int i=0; i< receivers.Length; i++)
            {
                int receiverID = receivers[i];
                //Get the properties needed for the creation of User object.
                string receiverName = DBConnect.GetUserNameByID(receiverID);
                string receiverSurname = DBConnect.GetUserSurnameByID(receiverID);
                DateTime receiverdateOfBirth = DBConnect.GetUserDateOfBirthByID(receiverID);
                User receiver = new User(receiverID, receiverName, receiverSurname, receiverdateOfBirth);

                //Create SharedLemma object
                SharedLemma sharedLemma = new SharedLemma(sender, receiver, lemma, '1', sendingDate, additionalNotes);
                result += DBConnect.Insert(sharedLemma);
			}

			// the result must be equal to the receivers.Length if all of the insertions were successful
			return result;
		}
    }
}
