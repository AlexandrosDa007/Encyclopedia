using System;
using System.Drawing;
using System.Windows.Forms;
using Encyclopedia.Controller;
using Encyclopedia.Model;

namespace Encyclopedia.View
{
    /// <summary>
    /// A small form that allows the User to select some (or all) of his/her Contacts and send a Lemma to them.
    /// </summary>
    public partial class SendForm : Form
    {
        #region Constructors
        public SendForm()
		{
			InitializeComponent();

			// fill contactsCheckedListBox with the user's contacts
			FillContactsListBox();

			// fill groupsCheckedListBox with the user's contact groups
			FillGroupListBox();
		}
        #endregion

        #region Private methods
        private void FillContactsListBox()
		{
			contactsCheckedListBox.Items.Clear();

			foreach (User contact in ContactsUserControl.Instance.ContactList)
			{
				contactsCheckedListBox.Items.Add(contact.Name + " " + contact.Surname);
			}
		}

		private void FillGroupListBox()
		{
			groupsCheckedListBox.Items.Clear();

			foreach (ContactGroup group in ContactsUserControl.Instance.GroupList)
			{
				groupsCheckedListBox.Items.Add(group.Name);
			}
		}

		private void closePictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void SendForm_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
							this.DisplayRectangle);
		}

		private void sendButton_Click(object sender, EventArgs e)
		{
			string lemmaTitle = null;
			if (LemmaViewUserControl.Instance.Mode == 0)
			{
				lemmaTitle = LemmaViewUserControl.Instance.Lemma.Title;
			}
			else
			{
				lemmaTitle = LemmaViewUserControl.Instance.EditedLemma.LemmaTitle;
			}

			int i = 0;
			int[] receiverIds = null;
			// TODO get checked contact ids for the receivers array
			if (contactsTabControl.SelectedTab == contactsTabControl.TabPages["contactsTabPage"])
			{
				receiverIds = new int[contactsCheckedListBox.CheckedItems.Count];

				CheckedListBox.CheckedItemCollection checkedContacts = contactsCheckedListBox.CheckedItems;
				foreach (object contactItem in checkedContacts)
				{
					string contactName = (contactItem as string).Split(new[] { ' ' }, 2)[0];
					
					foreach (User contact in ContactsUserControl.Instance.ContactList)
					{
						if (contact.Name.Equals(contactName))
						{
							receiverIds[i++] = contact.Id;
							break;
						}
					}
				}
			}
			else if (contactsTabControl.SelectedTab == contactsTabControl.TabPages["contactsTabPage"])
			{

			}
			
			string additionalNotes = notesTextBox.Text;

			//int rowsAffected = Controller.Message.sendMessage(UI.StartPage.account.User.Id, lemmaTitle, receiverIds, additionalNotes);
		}
        #endregion

    }
}
