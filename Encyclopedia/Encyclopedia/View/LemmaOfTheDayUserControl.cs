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
    public partial class LemmaOfTheDayUserControl : UserControl
    {
        private static LemmaOfTheDayUserControl _instance;

        public static LemmaOfTheDayUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LemmaOfTheDayUserControl();
                return _instance;

            }
        }
        public LemmaOfTheDayUserControl()
        {
            InitializeComponent();
        }
    }
}
