using Encyclopedia.Controller;
using Encyclopedia.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI;

namespace Encyclopedia.View
{
    public partial class ContactsProfileForm : Form
    {
        public Account account;

        public ContactsProfileForm(Account account)
        {
            InitializeComponent();
            this.account = account;
            setUp();
        }

        public void setUp()
        {
            nameTextBox.Text = account.User.Name;
            surnameTextBox.Text = account.User.Surname;
            emailTextBox.Text = account.Email;
            usernameTextBox.Text = account.Username;
            if (account.User.Gender.Equals('M'))
                genderMaleRB.Checked = true;
            else if (account.User.Gender.Equals('F'))
                genderFemaleRB.Checked = true;
            dateOfBirthDTP.Value = account.User.DateOfBirth;
            if (account.User.EducationLevel.Id == -999)
                educationLevelCB.SelectedText = "";
            else
                educationLevelCB.SelectedText = DBConnect.GetEducationLevelById(account.User.EducationLevel.Id).Name;
            if (account.User.Role.Id == -999)
                roleCB.SelectedText = "";
            else
                roleCB.SelectedText = DBConnect.GetRoleById(account.User.Role.Id).Name;
            descriptionRTB.Text = account.User.Description;
            if (account.User.Image != null)
                imagePB.Image = (Bitmap)((new ImageConverter()).ConvertFrom(account.User.Image));
            else
                imagePB.Image = Encyclopedia.Properties.Resources.default_avatar;

            removeButton.Visible = true;


        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            //remove from userContacts
            int res = DBConnect.Delete(new Contact(StartPage.account.User,account.User));
            if(res == 1)
            {
                MessageBox.Show("Contact Removed!");
                StartPage.contactList.Remove(account.User);
                ContactsUserControl.Instance.contactList = StartPage.contactList;
                ContactsUserControl.Instance.UpdateTabControl();
                Close();
            }
            else
            {
                MessageBox.Show("Something went wrong!!");
                Close();
            }
        }

		private void ContactsProfileForm_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
							this.DisplayRectangle);
		}
	}
}
