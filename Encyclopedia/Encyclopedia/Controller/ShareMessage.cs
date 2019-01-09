using Encyclopedia.Model;
using Encyclopedia.View;
using System;
using System.Net.Mail;
using System.Text;

namespace Encyclopedia.Controller
{
	/// <summary>
	/// Contains functions needed to implement 'Share Lemma' Feature, sending an email to all the receivers specified.
	/// </summary>
	class ShareMessage
    {
        // userID: the id of the current user logged in.
        // lemmaTitle: the lemma of  the title to be send.
        // receivers: array with the IDs of the receivers.
        // additional notes: a string with extra notes from the user.
        public static int SendMessage(int userID, string lemmaTitle, int[] receivers, string additionalNotes)
		{
			// Get the sender's account.
			User sender = new User();
			sender.Id = userID;
			Account senderAccount = DBConnect.GetAccountByUser(sender);

			// configure the specified lemma
			Lemma lemma;
			EditedLemma editedLemma;
			ConfigureLemma(userID, lemmaTitle, out lemma, out editedLemma);

			int receiversNotified = 0;
			for (int i = 0; i < receivers.Length; i++)
			{
				int receiverID = receivers[i];

				// Get the properties needed for the creation of the receiver's account.
				User user = new User();
				user.Id = receiverID;
				Account receiverAccount = DBConnect.GetAccountByUser(user);

				string body = "";
				if (LemmaViewUserControl.Instance.Mode == 0)
				{
					body = Encoding.UTF8.GetString(lemma.Body);
				}
				else
				{
					body = editedLemma.Body;
				}

				// configure receiver's mail address
				MailAddress toAddress = new MailAddress(receiverAccount.Email, receiverAccount.Username);

				// Sent mail
				receiversNotified += SendEmail(toAddress, senderAccount.Username, lemmaTitle, body, additionalNotes);
			}

			// the result must be equal to the receivers.Length if all of the emails were sent successfully
			return receiversNotified;
		}

		private static void ConfigureLemma(int userID, string lemmaTitle, out Lemma lemma, out EditedLemma editedLemma)
		{
			byte[] lemmaBody = null;
			int lemmaCategory = -999;
			lemma = null;
			editedLemma = null;
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
		}

		private static int SendEmail(MailAddress toAddress, string sendersUsername, string lemmaTitle, string lemmaBody, string additionalNotes)
		{
			try
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
				mailMessage.Subject = "A lemma shared from User: " + sendersUsername + " | Encyclopedia";
				mailMessage.IsBodyHtml = true;
				string htmlBody = "<p><b>Greetings " + toAddress.DisplayName + ",</b></p></br>" +
					"<p>" + sendersUsername + " noted the following additional information if any: </p>" +
					"<p>\"" + additionalNotes + "\"</p>" +
					"<p>Below you can read the whole shared lemma.</p></br>" +
					"<p>Happy Reading,</p>" +
					"<p>Encyclopedia Team.</p></br>" + "<hr>"+
					"</br><h1>"+lemmaTitle+"</h1></br>"+
					"<hr>"+lemmaBody;

				mailMessage.Body = htmlBody;

				// send email
                client.Send(mailMessage);
				// receiver notified successfully
                return 1;
            }
            catch(Exception e)
            {
				// receiver didn't get the email
                return 0;
            }
        }
    }
}
