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
    public partial class AfterLoginUserControl : UserControl
    {
        public Account Account { set; get; }

        public AfterLoginUserControl()
        {
            InitializeComponent();

			// update the connectUserLabel if a user is logged-in
			if (StartPage.account != null)
			{
				connectUserLabel.Text = "Welcome " + StartPage.account.Username + "!";
			}
		}

		private void logoutButton_Click(object sender, EventArgs e)
        {
            //logout function

            StartPage st = (StartPage)this.Parent.Parent;
            st.Logout();
     
           

            if (!st.mainPanel.Controls.Contains(Encyclopedia.View.LemmaOfTheDayUserControl.Instance))
            {
                st.mainPanel.Controls.Add(Encyclopedia.View.LemmaOfTheDayUserControl.Instance);
                Encyclopedia.View.LemmaOfTheDayUserControl.Instance.Dock = DockStyle.Fill;
                Encyclopedia.View.LemmaOfTheDayUserControl.Instance.BringToFront();

            }
            else
            {
                Encyclopedia.View.LemmaOfTheDayUserControl.Instance.BringToFront();
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
                FavouriteLemmataUserControl.Instance.BringToFront();
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

        public void SetImage()
        {
            if(Account.User.Image!=null)
                sideProfilePicture.Image = (Bitmap)((new ImageConverter()).ConvertFrom(Account.User.Image));
        }

		private void FeedbackPanel_Paint(object sender, PaintEventArgs e)
		{

		}

        private void logoLabel_Click(object sender, EventArgs e)
        {
            StartPage startP = (StartPage)this.Parent.Parent;

            if (!startP.mainPanel.Controls.Contains(Encyclopedia.View.LemmaOfTheDayUserControl.Instance))
            {
                startP.mainPanel.Controls.Add(Encyclopedia.View.LemmaOfTheDayUserControl.Instance);
                Encyclopedia.View.LemmaOfTheDayUserControl.Instance.Dock = DockStyle.Fill;
                Encyclopedia.View.LemmaOfTheDayUserControl.Instance.BringToFront();

            }
            else
            {
                Encyclopedia.View.LemmaOfTheDayUserControl.Instance.BringToFront();
            }
        }
    }
}
