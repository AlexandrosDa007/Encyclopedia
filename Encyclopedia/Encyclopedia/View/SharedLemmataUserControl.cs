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
    public partial class SharedLemmataUserControl : UserControl
    {
        private static SharedLemmataUserControl _instance;
        public static SharedLemmataUserControl Instance
        {
            get
            {

                if (_instance == null)
                    _instance = new SharedLemmataUserControl();
                return _instance;

            }
        }
        public SharedLemmataUserControl()
        {
            InitializeComponent();
        }
    }
}
