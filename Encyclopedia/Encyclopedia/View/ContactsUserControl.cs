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

			if (UI.StartPage.username != null)
			{
				ContactHandler.FillContacts(contactsListView, UI.StartPage.username);
			}
			/*
			ImageList imageList = new ImageList();
			Image[] images = new Image[3];
			images[0] = Image.FromFile("D:\\Witcher Info\\Unit Icons\\lyria_overview1.jpg");
			images[1] = Image.FromFile("D:\\Witcher Info\\Unit Icons\\knight.jpg");
			images[2] = Image.FromFile("D:\\Witcher Info\\Unit Icons\\vicovaro_2.jpg");

			imageList.Images.AddRange(images);

			contactsListView.LargeImageList = imageList;
			*/

        }

    }
}
