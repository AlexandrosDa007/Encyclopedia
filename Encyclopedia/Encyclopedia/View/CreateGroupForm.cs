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
		private ContactGroup Group { set; get; }
		Dictionary<int, bool> IfGroupMembers { set; get; }

		public CreateGroupForm(ContactGroup group)
        {
            InitializeComponent();
			Group = group;

			IfGroupMembers = null;
			if (Group != null)
			{
				// adjust the controls
				groupNameTextBox.Text = Group.Name;
				saveGroupButton.Text = "Update Group";

				// configure which of the user's contacts are in this specific group
				IfGroupMembers = ContactAndGroupHandler.CheckContactGroupMembers(group, ContactsUserControl.Instance.ContactList);

				deleteGroupButton.Visible = true;
			}
			else
			{
				groupNameTextBox.Text = "";
				saveGroupButton.Text = "Save Group";

				deleteGroupButton.Visible = false;
			}

			// fill contactsCheckedListBox with the user's contacts
			FillContactsListBox();
		}

		private void FillContactsListBox()
		{
			contactsCheckedListBox.Items.Clear();
			
			foreach (User contact in ContactsUserControl.Instance.ContactList)
			{
				if (IfGroupMembers != null)
				{
					int indexOfContact = contactsCheckedListBox.Items.Add(contact.Name + " " + contact.Surname);
					contactsCheckedListBox.SetItemChecked(indexOfContact, IfGroupMembers[contact.Id]);
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
			string groupName = groupNameTextBox.Text;
            if(groupName.Equals("") || groupName == null)
            {
                MessageBox.Show("  Give the group a name!");
                return;
            }
			if (Group == null)
			{
				CreateNewContactGroup(groupName);
			}
			else
            {
                UpdateGroup(groupName);
            }
        }

        private void UpdateGroup(string groupName)
        {

            Dictionary<int, bool> groupMembersBefore = IfGroupMembers;

            Dictionary<int, bool> groupMembersAfter = new Dictionary<int, bool>();

            int[] checkedContacts = GetCheckedContactsIds();
            List<int> checkedContactsList = checkedContacts.ToList<int>();
            foreach (User contact in ContactsUserControl.Instance.ContactList)
            {
                if (checkedContactsList.Contains(contact.Id))
                {
                    groupMembersAfter[contact.Id] = true;
                }
                else
                {
                    groupMembersAfter[contact.Id] = false;
                }
            }

            int exitCode = ContactAndGroupHandler.UpdateGroup(Group, groupName, groupMembersBefore, groupMembersAfter);
            if (exitCode == -1)
            {
                MessageBox.Show("  Something went wrong with the group name update. Please try again.\n");
            }
            else if (exitCode == ContactsUserControl.Instance.ContactList.Count)
            {
                DialogResult dialogResult = MessageBox.Show("  Your group \"" + groupName + "\" updated successfully!");
                if (dialogResult == DialogResult.OK)
                {
                    ContactsUserControl.Instance.UpdateTabControl();
                    this.Close();
                }
            }
        }

        private void CreateNewContactGroup(string groupName)
		{
			int[] memberIds = GetCheckedContactsIds();

			ContactGroup newGroup = ContactAndGroupHandler.CreateNewGroup(groupName, memberIds);
			if (newGroup.Id != -1)
			{
				ContactsUserControl.Instance.GroupList.Add(newGroup);

				DialogResult dialogResult = MessageBox.Show("  Your new group \"" + groupName + "\" created successfully!");
				if (dialogResult == DialogResult.OK)
				{
					ContactsUserControl.Instance.UpdateTabControl();
					this.Close();
				}
			}
			else
			{
				MessageBox.Show("  Something went wrong with the group creation. Please try again.\n");
			}
		}

		private int[] GetCheckedContactsIds()
		{
			int i = 0;
			int[] memberIds = new int[contactsCheckedListBox.CheckedItems.Count];

			CheckedListBox.CheckedItemCollection checkedContacts = contactsCheckedListBox.CheckedItems;
			foreach (object contactItem in checkedContacts)
			{
				string contactName = (contactItem as string).Split(new[] { ' ' }, 2)[0];
				string contactSurname = (contactItem as string).Split(new[] { ' ' }, 2)[1];

				foreach (User contact in ContactsUserControl.Instance.ContactList)
				{
					if (contact.Name.Equals(contactName) && contact.Surname.Equals(contactSurname))
					{
						memberIds[i++] = contact.Id;
						break;
					}
				}
			}

			return memberIds;
		}

		private void deleteGroupButton_Click(object sender, EventArgs e)
		{
			if (Group != null)
			{
				int rowsAffected = ContactAndGroupHandler.DeleteGroup(Group);
				if (rowsAffected == 1)
				{
					ContactsUserControl.Instance.GroupList.Remove(Group);

					DialogResult dialogResult = MessageBox.Show("  Your group \"" + Group.Name + "\" deleted successfully!");
					if (dialogResult == DialogResult.OK)
					{
						ContactsUserControl.Instance.UpdateTabControl();
						this.Close();
					}
				}
				else
				{
					MessageBox.Show("  Something went wrong with the group deletion. Please try again.\n");
				}
			}
		}
	}
}
