using System;
using System.Drawing;
using System.Windows.Forms;
using Encyclopedia.Controller;
using Encyclopedia.Model;

namespace Encyclopedia.View
{
    public partial class SendForm : Form
    {
        public SendForm()
		{
			InitializeComponent();

			// fill contactsCheckedListBox with the user's contacts
			FillContactsListBox();

			// fill groupsCheckedListBox with the user's contact groups
			FillGroupListBox();
		}

		private void FillContactsListBox()
		{
			contactsCheckedListBox.Items.Clear();

			foreach (User contact in ContactsUserControl.Instance.contactList)
			{
				contactsCheckedListBox.Items.Add(contact.Name + " " + contact.Surname);
			}
		}

		private void FillGroupListBox()
		{
			groupsCheckedListBox.Items.Clear();

			foreach (ContactGroup group in ContactsUserControl.Instance.groupList)
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
			if (LemmaViewUserControl.Instance.mode == 0)
			{
				lemmaTitle = LemmaViewUserControl.Instance.lemma.Title;
			}
			else
			{
				lemmaTitle = LemmaViewUserControl.Instance.editedLemma.LemmaTitle;
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
					string contactSurname = (contactItem as string).Split(new[] { ' ' }, 2)[1];

					foreach (User contact in ContactsUserControl.Instance.contactList)
					{
						if (contact.Name.Equals(contactName) && contact.Surname.Equals(contactSurname))
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
	}
}
