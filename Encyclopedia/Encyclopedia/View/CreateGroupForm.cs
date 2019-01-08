using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encyclopedia.Model;
using Encyclopedia.Controller;

namespace Encyclopedia.View
{
    public partial class CreateGroupForm : Form
    {
		private ContactGroup group;

        public CreateGroupForm(ContactGroup group)
        {
            InitializeComponent();

			Dictionary<int, bool> ifGroupMembers = null;
			if (group != null)
			{
				groupNameTextBox.Text = group.Name;
				saveGroupButton.Text = "Update Group";

				ifGroupMembers = ContactHandler.CheckContactGroupMembers(group, ContactsUserControl.Instance.ContactList);
			}
			else
			{
				groupNameTextBox.Text = "";
				saveGroupButton.Text = "Save Group";
			}

			// fill contactsCheckedListBox with the user's contacts
			FillContactsListBox(ifGroupMembers);
		}

		private void FillContactsListBox(Dictionary<int, bool> ifGroupMembers)
		{
			contactsCheckedListBox.Items.Clear();
			
			foreach (User contact in ContactsUserControl.Instance.ContactList)
			{
				if (ifGroupMembers != null)
				{
					int indexOfContact = contactsCheckedListBox.Items.Add(contact.Name + " " + contact.Surname);
					contactsCheckedListBox.SetItemChecked(indexOfContact, ifGroupMembers[contact.Id]);
				}
				else
				{
					int indexOfContact = contactsCheckedListBox.Items.Add(contact.Name + " " + contact.Surname);
					contactsCheckedListBox.SetItemChecked(indexOfContact, false);
				}
			}
		}

		private void closePictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void CreateGroupForm_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
							this.DisplayRectangle);
		}

		private void saveGroupButton_Click(object sender, EventArgs e)
		{

		}
	}
}
