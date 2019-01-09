using Encyclopedia.Model;
using Encyclopedia.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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

            byte[] lemmaBody = null;
            int lemmaCategory = -999;
            Lemma lemma = null;
            EditedLemma editedLemma = null;
            if (LemmaViewUserControl.Instance.Mode == 0)
            {
                //Get the properties needed for the creation of Lemma object
                lemmaBody = DBConnect.GetLemmaBodyByTitle(lemmaTitle);
                lemmaCategory = DBConnect.GetLemmaCategoryByTitle(lemmaTitle);
                lemma = new Lemma(lemmaTitle, lemmaBody, lemmaCategory);
            }
            else
            {
                User user = new User();
                user.Id = userID;
                editedLemma = DBConnect.GetEditedLemmaByUserAndTitle(lemmaTitle, user);
            }

            

            //Get the properties needed for the creation of User object.
            string userName = DBConnect.GetUserNameByID(userID);
            string userSurname = DBConnect.GetUserSurnameByID(userID);
            DateTime senderDateOfBirth = DBConnect.GetUserDateOfBirthByID(userID);
            //User sender = new User(userID, userName, userSurname, senderDateOfBirth);

            DateTime sendingDate = new DateTime();

			int result = 0;
            for (int i=0; i< receivers.Length; i++)
            {
                int receiverID = receivers[i];
                //Get the properties needed for the creation of User object.
                User user = new User();
                user.Id = receiverID;
                Account receiverAccount = DBConnect.GetAccountByUser(user);
                string receiverName = DBConnect.GetUserNameByID(receiverID);
                string receiverSurname = DBConnect.GetUserSurnameByID(receiverID);
                DateTime receiverdateOfBirth = DBConnect.GetUserDateOfBirthByID(receiverID);
                User receiver = new User(receiverID, receiverName, receiverSurname, receiverdateOfBirth);

                string body = "";
                if(LemmaViewUserControl.Instance.Mode == 0)
                {
                    body = Encoding.UTF8.GetString(lemma.Body);
                }
                else
                {
                    body = editedLemma.Body;
                }

                //Sent mail
                result = SendEmail(new MailAddress(receiverAccount.Email, receiverAccount.Username), receiverAccount.Username, lemmaTitle, body, additionalNotes);
			}

			// the result must be equal to the receivers.Length if all of the insertions were successful
			return result;
		}

        private static int SendEmail(MailAddress toAddress, string username,string lemmaTitle,string lemmaBody, string additionalNotes)
        {
            // configure sender's email address
            MailAddress fromAddress = new MailAddress("encyclopedia.noreply@gmail.com", "EncyclopediaSupport Team4");
            const string fromPassword = "mpla123P";  // ideally it should be encrypted

            // configure SMTP client properties
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(fromAddress.Address, fromPassword);

            // configure email message
            MailMessage mailMessage = new MailMessage(fromAddress, toAddress);
            mailMessage.Subject = "Lemma shared from User: "+username+" | Encyclopedia";
            mailMessage.IsBodyHtml = true;
            string htmlBody = "<p>"+additionalNotes+"</p>"+"<hr>"+
                "<h1>"+lemmaTitle+"</h1>"+
                "<hr>"+lemmaBody;

            mailMessage.Body = htmlBody;

            // send password recovery email
            try
            {
                client.Send(mailMessage);
                return 0;
            }
            catch(Exception e)
            {
                return 1;
            }
        }
    }
}
