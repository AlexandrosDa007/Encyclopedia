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
    /// <summary>
    /// A Form that opens when the User clicks on a contact. It contains information about that contact.
    /// </summary>
    public partial class ContactsProfileForm : Form
    {
        #region Properties
        public Account Account { set; get; }
        #endregion

        #region Constructors
        public ContactsProfileForm(Account account)
        {
            InitializeComponent();
            Account = account;
            setUp();
        }
        #endregion

        #region Private methods
        private void closePictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            //remove from userContacts
            int res = DBConnect.Delete(new Contact(StartPage.account.User, Account.User));
            if (res == 1)
            {
                MessageBox.Show("  The user removed successfully from your contacts!");
                foreach (User u in StartPage.contactList)
                {
                    if (Account.User.Id == u.Id)
                    {
                        StartPage.contactList.Remove(u);
                        break;
                    }

                }

                ContactsUserControl.Instance.ContactList = StartPage.contactList;
                ContactsUserControl.Instance.UpdateTabControl();
                Close();
            }
            else
            {
                MessageBox.Show("  Something went wrong!");
                Close();
            }
        }

        private void ContactsProfileForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
                            this.DisplayRectangle);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int res = DBConnect.Insert(new Contact(StartPage.account.User, Account.User));
            if (res == 1)
            {
                MessageBox.Show("  The user added successfully to your contacts!");
                StartPage.contactList.Add(Account.User);
                ContactsUserControl.Instance.ContactList = StartPage.contactList;
                ContactsUserControl.Instance.UpdateTabControl();
                Close();
            }
            else
            {
                MessageBox.Show("  Something went wrong!");
                Close();
            }
        }
        #endregion

        #region Public methods
        public void setUp()
        {
            nameTextBox.Text = Account.User.Name;
            surnameTextBox.Text = Account.User.Surname;
            emailTextBox.Text = Account.Email;
            usernameTextBox.Text = Account.Username;
            if (Account.User.Gender.Equals('M'))
                genderMaleRB.Checked = true;
            if (Account.User.Gender.Equals('F'))
                genderFemaleRB.Checked = true;
            dateOfBirthDTP.Value = Account.User.DateOfBirth;
            if (Account.User.EducationLevel.Id == -999)
                educationLevelTextBox.Text = "";
            else
                educationLevelTextBox.Text = DBConnect.GetEducationLevelById(Account.User.EducationLevel.Id).Name;
            if (Account.User.Role.Id == -999)
                roleLevelTextBox.Text = "";
            else
                roleLevelTextBox.Text = DBConnect.GetRoleById(Account.User.Role.Id).Name;
            descriptionRTB.Text = Account.User.Description;
            if (Account.User.Image != null)
                imagePB.Image = (Bitmap)((new ImageConverter()).ConvertFrom(Account.User.Image));
            else
                imagePB.Image = Encyclopedia.Properties.Resources.default_avatar;

            addButton.Visible = true;
            //check if user is in my contacts
            foreach (User u in StartPage.contactList)
            {
                if (u.Id == Account.User.Id)
                {
                    removeButton.Visible = true;
                    addButton.Visible = false;
                    break;
                }
                else
                {
                    addButton.Visible = true;
                    
                }
            }
        }
        #endregion

    }
}
