using Encyclopedia.Controller;
using System.Windows.Forms;

namespace Encyclopedia.View
{
    public partial class ContactsUserControl : UserControl
    {
        private static ContactsUserControl _instance;


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

			if (UI.StartPage.account != null)
			{
				ContactHandler.FillContacts(contactsListView, UI.StartPage.account);
			}
        }

    }
}
