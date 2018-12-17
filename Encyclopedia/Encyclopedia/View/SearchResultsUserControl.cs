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
    public partial class SearchResultsUserControl : UserControl
    {
        private static SearchResultsUserControl _instance;

        public static SearchResultsUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SearchResultsUserControl();
                return _instance;

            }
        }
        public SearchResultsUserControl()
        {
            InitializeComponent();
        }
    }
}
