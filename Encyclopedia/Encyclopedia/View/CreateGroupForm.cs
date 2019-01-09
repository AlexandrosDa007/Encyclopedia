using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Encyclopedia.Model;
using Encyclopedia.Controller;

namespace Encyclopedia.View
{
	/// <summary>
	/// A form for creating and editing user's contact groups.
	/// </summary>
	public partial class CreateGroupForm : Form
    {
		#region Properties
		private ContactGroup Group { set; get; }
		private Dictionary<int, bool> IfGroupMembers { set; get; }
		#endregion

		#region Constructors
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
				// adjust the controls
				groupNameTextBox.Text = "";
				saveGroupButton.Text = "Save Group";

				deleteGroupButton.Visible = false;
			}

			// fill contactsCheckedListBox with the user's contacts
			FillContactsListBox();
		}
		#endregion

		#region Private methods
		private void FillContactsListBox()
		{
			contactsCheckedListBox.Items.Clear();
			
			foreach (User contact in ContactsUserControl.Instance.ContactList)
			{
				if (IfGroupMembers != null)
				{
					// if it is an existing group, check its members
					int indexOfContact = contactsCheckedListBox.Items.Add(contact.Name + " " + contact.Surname);
					contactsCheckedListBox.SetItemChecked(indexOfContact, IfGroupMembers[contact.Id]);
				}
				else
				{
					// if it is a new one, then set all of them to unchecked
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
			// get the inserted group name
			string groupName = groupNameTextBox.Text;
			// show a message if the user didn't provide any
            if(groupName.Equals("") || groupName == null)
            {
                MessageBox.Show("  Give the group a name!");
                return;
            }

			if (Group == null)
			{
				// if it is a new group, then create it
				CreateNewContactGroup(groupName);
			}
			else
            {
				// if it is an existing one, then update it
                UpdateGroup(groupName);
            }
        }

		private void CreateNewContactGroup(string groupName)
		{
			// get the contacts that were checked
			int[] memberIds = GetCheckedContactsIds();

			// try to create a new group
			ContactGroup newGroup = ContactAndGroupHandler.CreateNewGroup(groupName, memberIds);
			if (newGroup.Id != -1)
			{
				// if the group creation was successful, then add the group to the user's group list
				ContactsUserControl.Instance.GroupList.Add(newGroup);

				// display a feedback dialog
				DialogResult dialogResult = MessageBox.Show("  Your new group \"" + groupName + "\" created successfully!");
				if (dialogResult == DialogResult.OK)
				{
					// update the groups tab page
					ContactsUserControl.Instance.UpdateTabControl();
					this.Close();
				}
			}
			else
			{
				// something was wrong with the group creation, inform the user
				MessageBox.Show("  Something went wrong with the group creation. Please try again.\n");
			}
		}

		private int[] GetCheckedContactsIds()
		{
			int i = 0;
			int[] memberIds = new int[contactsCheckedListBox.CheckedItems.Count];

			// get the checked items collection
			CheckedListBox.CheckedItemCollection checkedContacts = contactsCheckedListBox.CheckedItems;
			foreach (object contactItem in checkedContacts)
			{
				// divide the contact's name and surname
				string contactName = (contactItem as string).Split(new[] { ' ' }, 2)[0];
				string contactSurname = (contactItem as string).Split(new[] { ' ' }, 2)[1];

				foreach (User contact in ContactsUserControl.Instance.ContactList)
				{
					// find the checked contact's id
					if (contact.Name.Equals(contactName) && contact.Surname.Equals(contactSurname))
					{
						memberIds[i++] = contact.Id;
						break;
					}
				}
			}

			return memberIds;
		}

		private void UpdateGroup(string groupName)
        {
			// get the group's members before the update
            Dictionary<int, bool> groupMembersBefore = IfGroupMembers;

            Dictionary<int, bool> groupMembersAfter = new Dictionary<int, bool>();

			// get the contacts that were checked
			List<int> checkedContacts = GetCheckedContactsIds().ToList<int>();
            foreach (User contact in ContactsUserControl.Instance.ContactList)
            {
				// configure the checked contacts after the update
                if (checkedContacts.Contains(contact.Id))
                {
                    groupMembersAfter[contact.Id] = true;
                }
                else
                {
                    groupMembersAfter[contact.Id] = false;
                }
            }

			// try to update the group
            int exitCode = ContactAndGroupHandler.UpdateGroup(Group, groupName, groupMembersBefore, groupMembersAfter);
            if (exitCode == -1)
            {
				// something was wrong with the name update
                MessageBox.Show("  Something went wrong with the group's name update. Please try again.\n");
            }
            else if (exitCode == ContactsUserControl.Instance.ContactList.Count)
            {
				// if all the contacts updated correctly
                DialogResult dialogResult = MessageBox.Show("  Your group \"" + groupName + "\" updated successfully!");
                if (dialogResult == DialogResult.OK)
                {
					// update the groups tab page
					ContactsUserControl.Instance.UpdateTabControl();
                    this.Close();
                }
            }
        }
		
		private void deleteGroupButton_Click(object sender, EventArgs e)
		{
			if (Group != null)
			{
				// try to delete group
				int rowsAffected = ContactAndGroupHandler.DeleteGroup(Group);
				if (rowsAffected == 1)
				{
					// deletion successful, remove the specified group from the user's group list
					ContactsUserControl.Instance.GroupList.Remove(Group);

					// inform the user
					DialogResult dialogResult = MessageBox.Show("  Your group \"" + Group.Name + "\" deleted successfully!");
					if (dialogResult == DialogResult.OK)
					{
						// update the group's tab page
						ContactsUserControl.Instance.UpdateTabControl();
						this.Close();
					}
				}
				else
				{
					// something was wrong with the group creation, inform the user
					MessageBox.Show("  Something went wrong with the group deletion. Please try again.\n");
				}
			}
		}
		#endregion
	}
}
