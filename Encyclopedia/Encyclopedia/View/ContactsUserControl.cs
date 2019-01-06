using Encyclopedia.Controller;
using Encyclopedia.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Encyclopedia.View
{
    public partial class ContactsUserControl : UserControl
    {
        private static ContactsUserControl _instance;

		public List<User> contactList = null;
		public List<ContactGroup> groupList = null;

        public static ContactsUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ContactsUserControl();
                return _instance;
            }
        }

        public ContactsUserControl()
        {
            InitializeComponent();
        }

		private void contactsTabControl_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateTabControl();
		}

		public void UpdateTabControl()
		{
			if (UI.StartPage.account != null)
			{
				// update the tab that is selected
				if (contactsTabControl.SelectedTab == contactsTabControl.TabPages["contactsTabPage"])
				{
					ContactHandler.FillContacts(contactsListView, contactList);
				}
				else if (contactsTabControl.SelectedTab == contactsTabControl.TabPages["groupTabPage"])
				{
					ContactHandler.FillGroups(groupListView, groupList);
				}
			}
		}

        private void searchContactsTextBox_Enter(object sender, System.EventArgs e)
        {
            if (searchContactsTextBox.Text.Trim() != "" || searchContactsTextBox.Text != null)

            {

                searchContactsTextBox.Text = "";

            }
        }

        private void contactsListView_DoubleClick(object sender, System.EventArgs e)
        {
            string userNameAndSurname = contactsListView.SelectedItems[0].Text;
            string userName = userNameAndSurname.Split(new[] { ' ' }, 2)[0];
            User contactUser = null;
            foreach(User u in contactList)
            {
                if (u.Name.Equals(userName))
                {
                    contactUser = u;
                }
            }

            Account contactAccount = DBConnect.GetAccountByUser(contactUser);

            //Open a ContactsProfileForm
            ContactsProfileForm form = new ContactsProfileForm(contactAccount);
            form.Show();

        }

		private void createGroupButton_Click(object sender, EventArgs e)
		{

		}
	}
}
