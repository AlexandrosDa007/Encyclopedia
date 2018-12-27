using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
    }
}
