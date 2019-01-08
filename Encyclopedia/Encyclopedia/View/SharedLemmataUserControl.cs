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
    /// <summary>
    /// A User Control to display the User's shared Lemmas
    /// </summary>
    public partial class SharedLemmataUserControl : UserControl
    {
        /// <summary>
        /// A static reference to the Instance of this Control
        /// </summary>
        private static SharedLemmataUserControl _instance;
        /// <summary>
        /// A static reference to the public Instance of this Control
        /// </summary>
        public static SharedLemmataUserControl Instance
        {
            get
            {

                if (_instance == null)
                    _instance = new SharedLemmataUserControl();
                return _instance;

            }
        }

        #region Constructors
        public SharedLemmataUserControl()
        {
            InitializeComponent();
        }
        #endregion
    }
}
