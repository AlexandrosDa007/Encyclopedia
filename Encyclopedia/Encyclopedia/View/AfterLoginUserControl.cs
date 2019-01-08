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
using Encyclopedia.Model;

namespace Encyclopedia.View
{
    /// <summary>
    /// A User Control for the left panel of StartPage. This loads when a user in logged in.
    /// </summary>
    public partial class AfterLoginUserControl : UserControl
    {
        #region Properties
        public Account Account { set; get; }
        #endregion

        #region Constructors
        public AfterLoginUserControl()
        {
            InitializeComponent();

			// update the connectUserLabel if a user is logged-in
			if (StartPage.account != null)
			{
				connectUserLabel.Text = "Welcome " + StartPage.account.Username + "!";
			}
		}
        #endregion

        #region Private methods
        private void logoutButton_Click(object sender, EventArgs e)
        {
            //logout function

            StartPage st = (StartPage)this.Parent.Parent;
            st.Logout();
     
            if (!st.mainPanel.Controls.Contains(Encyclopedia.View.FeaturedLemmaUserControl.Instance))
            {
                st.mainPanel.Controls.Add(Encyclopedia.View.FeaturedLemmaUserControl.Instance);
                Encyclopedia.View.FeaturedLemmaUserControl.Instance.Dock = DockStyle.Fill;
                Encyclopedia.View.FeaturedLemmaUserControl.Instance.BringToFront();
            }
            else
            {
                Encyclopedia.View.FeaturedLemmaUserControl.Instance.BringToFront();
            }
        }

        private void contactsButton_Click(object sender, EventArgs e)
        {
			StartPage startP = (StartPage)this.Parent.Parent;

            if (!startP.mainPanel.Controls.Contains(ContactsUserControl.Instance))
            {
				startP.mainPanel.Controls.Add(ContactsUserControl.Instance);
				ContactsUserControl.Instance.Dock = DockStyle.Fill;
				ContactsUserControl.Instance.BringToFront();
            }
            else
				ContactsUserControl.Instance.BringToFront();
		}

        private void editedButton_Click(object sender, EventArgs e)
        {
			StartPage startP = (StartPage)this.Parent.Parent;
            
            if (!startP.mainPanel.Controls.Contains(EditedLemmataUserControl.Instance))
            {
				startP.mainPanel.Controls.Add(EditedLemmataUserControl.Instance);
                EditedLemmataUserControl.Instance.Dock = DockStyle.Fill;
                EditedLemmataUserControl.Instance.BringToFront();
            }
            else
                EditedLemmataUserControl.Instance.BringToFront();
        }

        private void favouritesButton_Click(object sender, EventArgs e)
        {
			StartPage startP = (StartPage)this.Parent.Parent;

			if (!startP.mainPanel.Controls.Contains(FavouriteLemmataUserControl.Instance))
            {
				startP.mainPanel.Controls.Add(FavouriteLemmataUserControl.Instance);
                FavouriteLemmataUserControl.Instance.Dock = DockStyle.Fill;
                FavouriteLemmataUserControl.Instance.BringToFront();
            }
            else
                FavouriteLemmataUserControl.Instance.BringToFront();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(this.Account);
            profileForm.ShowDialog();
            if (profileForm.UpdatedSuccessfully)
            {
                //update success
                this.Account = profileForm.Account;
                SetImage();
            }
        }

        private void logoLabel_Click(object sender, EventArgs e)
        {
            StartPage startP = (StartPage)this.Parent.Parent;

            if (!startP.mainPanel.Controls.Contains(Encyclopedia.View.FeaturedLemmaUserControl.Instance))
            {
                startP.mainPanel.Controls.Add(Encyclopedia.View.FeaturedLemmaUserControl.Instance);
                Encyclopedia.View.FeaturedLemmaUserControl.Instance.Dock = DockStyle.Fill;
                Encyclopedia.View.FeaturedLemmaUserControl.Instance.BringToFront();
            }
            else
            {
                Encyclopedia.View.FeaturedLemmaUserControl.Instance.BringToFront();
            }
        }

        private void sharedWithMeButton_Click(object sender, EventArgs e)
        {
            StartPage startP = (StartPage)this.Parent.Parent;

            if (!startP.mainPanel.Controls.Contains(SharedLemmataUserControl.Instance))
            {
                startP.mainPanel.Controls.Add(SharedLemmataUserControl.Instance);
                SharedLemmataUserControl.Instance.Dock = DockStyle.Fill;
                SharedLemmataUserControl.Instance.BringToFront();
            }
            else
                SharedLemmataUserControl.Instance.BringToFront();

        }
        #endregion

        #region Public methods
        public void SetImage()
        {
            if (Account.User.Image != null)
                sideProfilePicture.Image = (Bitmap)((new ImageConverter()).ConvertFrom(Account.User.Image));
        }
        #endregion
    }
}
