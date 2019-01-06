using Encyclopedia.Controller;
using Encyclopedia.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Encyclopedia.View
{
    public partial class ContactsUserControl : UserControl
    {
        private static ContactsUserControl _instance;

		public List<User> contactList = null;
		public List<string> groupList = null;

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
    }
}
