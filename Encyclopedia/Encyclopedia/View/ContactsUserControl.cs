using Encyclopedia.Controller;
using Encyclopedia.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Encyclopedia.View
{
    public partial class ContactsUserControl : UserControl
    {
        private static ContactsUserControl _instance;
		private bool contactsFilled = false;
		private bool groupsFilled = false;

		List<User> contactList = null;
		List<ContactGroup> groupList = null;

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

			UpdateTabControl(false);
        }

		private void refreshButton_Click(object sender, System.EventArgs e)
		{
			UpdateTabControl(true);
		}

		private void contactsTabControl_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateTabControl(false);
		}

		private void UpdateTabControl(bool refresh)
		{
			if (UI.StartPage.account != null)
			{
				// update the tab that is selected
				if (contactsTabControl.SelectedTab == contactsTabControl.TabPages["contactsTabPage"])
				{
					if (refresh || !contactsFilled || contactList == null)
					{
						ContactHandler.FillContacts(contactsListView, UI.StartPage.account);
						contactsFilled = true;
					}
				}
				else if (contactsTabControl.SelectedTab == contactsTabControl.TabPages["groupTabPage"])
				{
					if (refresh || !groupsFilled || groupList == null)
					{
						ContactHandler.FillGroups(groupListView, UI.StartPage.account);
						groupsFilled = true;
					}
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
