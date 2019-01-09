using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Encyclopedia.Controller;
using Encyclopedia.Model;
using System.Linq;

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
			
            List<int> receiverIds = new List<int>();
			// TODO get checked contact ids for the receivers array
			if (contactsTabControl.SelectedTab == contactsTabControl.TabPages["contactsTabPage"])
			{
				GetCheckedContactsIds(receiverIds);
			}
			else if (contactsTabControl.SelectedTab == contactsTabControl.TabPages["groupTabPage"])
			{
				GetContactsIdsFromCheckedGroups(receiverIds);
			}
		
			string additionalNotes = notesTextBox.Text;

			int receiversNotified = ShareMessage.SendMessage(UI.StartPage.account.User.Id, lemmaTitle, receiverIds.ToArray(), additionalNotes);
            if(receiversNotified == receiverIds.ToArray().Length)
            {
				// all of the receivers got the email successfully
                MessageBox.Show("  Mail sent successfully to all of the receivers!");
                Close();
            }
            else
            {
                MessageBox.Show("  Something went wrong! Some of the receivers didn't get your email. Please try again.");
                Close();
            }
        }

		private void GetContactsIdsFromCheckedGroups(List<int> receiverIds)
		{
			CheckedListBox.CheckedItemCollection checkedGroups = groupsCheckedListBox.CheckedItems;
			List<ContactGroup> listOfContactGroups = new List<ContactGroup>();
			foreach (object contactItem in checkedGroups)
			{
				string groupName = (contactItem as string);

				foreach (ContactGroup group in ContactsUserControl.Instance.GroupList)
				{
					if (group.Name.Equals(groupName))
					{
						listOfContactGroups.Add(group);
						break;
					}
				}
			}

			foreach (ContactGroup group in listOfContactGroups)
			{
				List<int> idList = DBConnect.GetContactGroupMembers(group, group.Owner.Id);
				receiverIds.AddRange(idList);
			}

			List<int> distictIds = receiverIds.Distinct().ToList();
			receiverIds.Clear();
			receiverIds.AddRange(distictIds);
		}

		private void GetCheckedContactsIds(List<int> receiverIds)
		{
			CheckedListBox.CheckedItemCollection checkedContacts = contactsCheckedListBox.CheckedItems;
			foreach (object contactItem in checkedContacts)
			{
				string contactName = (contactItem as string).Split(new[] { ' ' }, 2)[0];
				string contactSurname = (contactItem as string).Split(new[] { ' ' }, 2)[1];

				foreach (User contact in ContactsUserControl.Instance.ContactList)
				{
					if (contact.Name.Equals(contactName) && contact.Surname.Equals(contactSurname))
					{
						receiverIds.Add(contact.Id);
						break;
					}
				}
			}
		}
		#endregion

	}
}
