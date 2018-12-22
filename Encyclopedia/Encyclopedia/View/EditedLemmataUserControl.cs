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
    public partial class EditedLemmataUserControl : UserControl
    {
        public EditedLemmataUserControl()
        {
            InitializeComponent();
        }

        private static EditedLemmataUserControl _instance;


        public static EditedLemmataUserControl Instance
        {
            get
            {

                if (_instance == null)
                    _instance = new EditedLemmataUserControl();
                return _instance;

            }
        }
    }
}
