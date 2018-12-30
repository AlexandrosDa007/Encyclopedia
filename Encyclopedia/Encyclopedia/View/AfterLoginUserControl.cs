using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI;

namespace Encyclopedia.View
{
    public partial class AfterLoginUserControl : UserControl
    {
        public AfterLoginUserControl()
        {
            InitializeComponent();

			// update the connectUserLabel and the sideProfilePicture if the user is logged-in
			if (StartPage.username != null)
			{
				connectUserLabel.Text = "Welcome " + StartPage.username + "!";
				// TODO picture
			}
		}

		private void logoutButton_Click(object sender, EventArgs e)
        {
            //logout function
            StartPage st = (StartPage)this.Parent.Parent;

            foreach (Control x in st.controlsBeforeLogin)
            {
                x.Visible = true;
            }
            st.newLeftPanel.Controls.Remove(this);
        }

        private void contactsButton_Click(object sender, EventArgs e)
        {
			StartPage startP = (StartPage)this.Parent.Parent;

            if (!startP.Controls.Contains(ContactsUserControl.Instance))
            {
				startP.searchPanel.Controls.Add(ContactsUserControl.Instance);
				ContactsUserControl.Instance.Dock = DockStyle.Fill;
				ContactsUserControl.Instance.BringToFront();
				
            }
            else
				ContactsUserControl.Instance.BringToFront();
		}

        private void editedButton_Click(object sender, EventArgs e)
        {
			StartPage startP = (StartPage)this.Parent.Parent;

			if (!startP.Controls.Contains(EditedLemmataUserControl.Instance))
            {
				startP.searchPanel.Controls.Add(EditedLemmataUserControl.Instance);
                EditedLemmataUserControl.Instance.Dock = DockStyle.Fill;
                EditedLemmataUserControl.Instance.BringToFront();

            }
            else
                FavouriteLemmataUserControl.Instance.BringToFront();
        }

        private void favouritesButton_Click(object sender, EventArgs e)
        {
			StartPage startP = (StartPage)this.Parent.Parent;

			if (!startP.Controls.Contains(FavouriteLemmataUserControl.Instance))
            {
				startP.searchPanel.Controls.Add(FavouriteLemmataUserControl.Instance);
                FavouriteLemmataUserControl.Instance.Dock = DockStyle.Fill;
                FavouriteLemmataUserControl.Instance.BringToFront();

            }
            else
                FavouriteLemmataUserControl.Instance.BringToFront();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.ShowDialog();
        }
    }
}
