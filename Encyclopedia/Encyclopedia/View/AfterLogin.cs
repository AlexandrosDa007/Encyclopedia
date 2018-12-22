using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encyclopedia.View
{
    public partial class AfterLogin : Form
    {
        public AfterLogin()
        {
            InitializeComponent();
        }

        private void favouritesButton_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(Encyclopedia.View.FavouriteLemmataUserControl.Instance))
            {
                mainPanel.Controls.Add(Encyclopedia.View.FavouriteLemmataUserControl.Instance);
                Encyclopedia.View.FavouriteLemmataUserControl.Instance.Dock = DockStyle.Fill;
                Encyclopedia.View.FavouriteLemmataUserControl.Instance.BringToFront();

            }
            else
                Encyclopedia.View.FavouriteLemmataUserControl.Instance.BringToFront();

        }

        private void editedButton_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(Encyclopedia.View.EditedLemmataUserControl.Instance))
            {
                mainPanel.Controls.Add(Encyclopedia.View.EditedLemmataUserControl.Instance);
                Encyclopedia.View.EditedLemmataUserControl.Instance.Dock = DockStyle.Fill;
                Encyclopedia.View.EditedLemmataUserControl.Instance.BringToFront();

            }
            else
                Encyclopedia.View.EditedLemmataUserControl.Instance.BringToFront();
        }
    }
}
