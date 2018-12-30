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
            if (!Controls.Contains(Encyclopedia.View.ContactsUserControl.Instance))
            {
                Controls.Add(Encyclopedia.View.ContactsUserControl.Instance);
                Encyclopedia.View.ContactsUserControl.Instance.Dock = DockStyle.Fill;
                Encyclopedia.View.ContactsUserControl.Instance.BringToFront();

            }
            else
                Encyclopedia.View.ContactsUserControl.Instance.BringToFront();

        }

        private void editedButton_Click(object sender, EventArgs e)
        {
            if (!Controls.Contains(Encyclopedia.View.EditedLemmataUserControl.Instance))
            {
                Controls.Add(Encyclopedia.View.EditedLemmataUserControl.Instance);
                Encyclopedia.View.EditedLemmataUserControl.Instance.Dock = DockStyle.Fill;
                Encyclopedia.View.EditedLemmataUserControl.Instance.BringToFront();

            }
            else
                Encyclopedia.View.FavouriteLemmataUserControl.Instance.BringToFront();
        }

        private void favouritesButton_Click(object sender, EventArgs e)
        {
            if (!Controls.Contains(Encyclopedia.View.FavouriteLemmataUserControl.Instance))
            {
                Controls.Add(Encyclopedia.View.FavouriteLemmataUserControl.Instance);
                Encyclopedia.View.FavouriteLemmataUserControl.Instance.Dock = DockStyle.Fill;
                Encyclopedia.View.FavouriteLemmataUserControl.Instance.BringToFront();

            }
            else
                Encyclopedia.View.FavouriteLemmataUserControl.Instance.BringToFront();
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
            sideProfilePicture.Image = (Bitmap)((new ImageConverter()).ConvertFrom(Account.User.Image));
        }
    }
}
