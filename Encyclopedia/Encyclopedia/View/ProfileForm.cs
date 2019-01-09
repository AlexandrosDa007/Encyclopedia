using Encyclopedia.Controller;
using Encyclopedia.Model;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Encyclopedia.View
{
    /// <summary>
    /// A form that displays the User's profile information
    /// </summary>
    public partial class ProfileForm : Form
    {
        #region Properties
        public Account Account { set; get; }
        public UI.StartPage st { set; get; }
        public bool UpdatedSuccessfully { set; get; }
        #endregion

        #region Constructors
        public ProfileForm(Account account,UI.StartPage st)
        {
            InitializeComponent();

			DynamicUIControlsHandler.FillEducationLevels(educationLevelCB);
			DynamicUIControlsHandler.FillRoles(roleCB);

            this.Account = account;
            this.st = st;
            SetAccountData();
            UpdatedSuccessfully = false;
        }
        #endregion

        #region Private methods
        private void closePictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetAccountData()
        {
            nameTextBox.Text = Account.User.Name;
            surnameTextBox.Text = Account.User.Surname;
            telTexBox.Text = Account.User.Tel;
            emailTextBox.Text = Account.Email;
            usernameTextBox.Text = Account.Username;
            if (Account.User.Gender == 'M')
                genderMaleRB.Checked = true;
            if (Account.User.Gender == 'F')
                genderFemaleRB.Checked = true;
            dateOfBirthDTP.Value = Account.User.DateOfBirth;

            if(Account.User.EducationLevel.Id != -999)
                educationLevelCB.SelectedIndex = Account.User.EducationLevel.Id - 1;
            if (Account.User.Role.Id != -999)
                roleCB.SelectedIndex = Account.User.Role.Id - 1;

            descriptionRTB.Text = Account.User.Description;
			if (Account.User.Image != null)
			{
				imagePB.Image = (Bitmap)((new ImageConverter()).ConvertFrom(Account.User.Image));
				imagePathTB.Text = "keepTheSameImage";
			}
			else
			{
				imagePathTB.Text = "";
			}
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Enabled = true;
            surnameTextBox.Enabled = true;
            telTexBox.Enabled = true;
            passwordTextBox.Enabled = true;
            passwordConfirmTextBox.Enabled = true;
            genderGroupBox.Enabled = true;
            dateOfBirthDTP.Enabled = true;
            roleCB.Enabled = true;
            educationLevelCB.Enabled = true;
            descriptionRTB.Enabled = true;
            saveButton.Visible = true;
            browseButton.Enabled = true;
			clearPhotoButton.Enabled = true;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "  Please select an image for your account.";

            // show only image file formats
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.PNG;*.GIF)|*.BMP;*.JPG;*.JPEG;*.PNG;*.GIF";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // check if the file size isn't bigger than 1 MB approx. (measured in bytes)
                long imageLength = new FileInfo(openFileDialog1.FileName).Length;
                if (imageLength > 1000000)
                {
                    MessageBox.Show("  Please pick a smaller image!");
                    return;
                }

				imagePB.Image = Image.FromFile(openFileDialog1.FileName);
				imagePathTB.Text = openFileDialog1.FileName;
			}
            else
            {
                MessageBox.Show("  Please pick an image!");
                return;
            }
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            feedbackLabel1.Text = "";
            //if 0 then every check is passed | 3 - name empty | 4 - surname empty
            //5 - password empty | 6 - password doesnt match | 7 - password invalid | 8 - something went wrong in database
            int okayToUpdate = 0;
            //take all input from fields
            if (nameTextBox.Text == "" || nameTextBox.Text == null)
                okayToUpdate = 3;
            else
                Account.User.Name = nameTextBox.Text;
            if (surnameTextBox.Text == "" || surnameTextBox.Text == null)
                okayToUpdate = 4;
            else
                Account.User.Surname = surnameTextBox.Text;
            if (telTexBox.Text == "" || telTexBox.Text == null)
                Account.User.Tel = "";
            else
                Account.User.Tel = telTexBox.Text;
            if(educationLevelCB.SelectedIndex != -1)
            {
                Account.User.EducationLevel.Name = educationLevelCB.GetItemText(educationLevelCB.SelectedItem);
                Account.User.EducationLevel.Id = educationLevelCB.SelectedIndex + 1;
            }
            else
            {
                Account.User.EducationLevel.Name = "";
                Account.User.EducationLevel.Id = -999;
            }

            if (roleCB.SelectedIndex != -1)
            {
                Account.User.Role.Name = roleCB.GetItemText(roleCB.SelectedItem);
                Account.User.Role.Id = roleCB.SelectedIndex + 1;
            }
            else
            {
                Account.User.Role.Name = "";
                Account.User.Role.Id = -999;
            }
            if (descriptionRTB.Text == null || descriptionRTB.Text == "")
                Account.User.Description = "";
            else
                Account.User.Description = descriptionRTB.Text;
			//check image
			if (imagePathTB.Text.Length != 0 && !imagePathTB.Text.Equals("keepTheSameImage"))
			{
				// update the image, the user chose a new one
				string fileName = imagePathTB.Text;

				FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
				BinaryReader br = new BinaryReader(fs);
				byte[] imageData = br.ReadBytes((int)fs.Length);

				Account.User.Image = imageData;
			}
            else if (imagePathTB.Text.Length == 0)
            {
				// remove the image, the user didn't choose any image
                Account.User.Image = null;
            }
			// else, keep the same image, so don't change the Account.User.Image value at all


			if (genderMaleRB.Checked)
                Account.User.Gender = 'M';
            else if (genderFemaleRB.Checked)
                Account.User.Gender = 'F';
            Account.User.DateOfBirth = dateOfBirthDTP.Value;

            //check password
           
            string pass = passwordTextBox.Text;
            string passConf = passwordConfirmTextBox.Text;

            if (pass.Equals("") || pass == null)
                okayToUpdate = 5;
            
            if (pass.Equals(passConf))
            {
                if (pass.Length < 8 || !pass.Any(char.IsNumber) || !pass.Any(char.IsLetter))
                {
                    //lathos password
                    okayToUpdate = 7;
                }
                else
                {
                    if(okayToUpdate == 0)
                    {
                        //try to update

                        //make password hash and create salt
                        string salt = PasswordUtilities.CreateSalt(16);
                        string passwordHashed = PasswordUtilities.GenerateSHA256Hash(pass, salt);
                        Account.PasswordSalt = salt;
                        Account.SaltedPasswordHash = passwordHashed;

						// set up account username for interoperability purposes
						Account.Username = usernameTextBox.Text;

                        int accountAffected = DBConnect.Update(Account);
                        int userAffected = DBConnect.Update(Account.User);
                        if (accountAffected == 1 && userAffected == 1)
                        {
                            UpdatedSuccessfully = true;
                            // Account update succeded
                            MessageBox.Show("  Account updated successfully!\n");
                            feedbackLabel1.Text = "";
                            this.Close();
                        }
                        else
                        {
                            // Account update not successful
                            okayToUpdate = 8;
                        }
                    }
                }
            }
            else
            {
                okayToUpdate = 6;
            }

            feedbackLabel1.ForeColor = Color.Black;

            // fade out effect in feedbackLabel message
            Timer timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

            updateFeedbackLabel(okayToUpdate);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int fadingSpeed = 5;
            feedbackLabel1.ForeColor = Color.FromArgb(feedbackLabel1.ForeColor.R + fadingSpeed, feedbackLabel1.ForeColor.G + fadingSpeed, feedbackLabel1.ForeColor.B + fadingSpeed);

            if (feedbackLabel1.ForeColor.R >= this.BackColor.R)
            {
                ((Timer)sender).Stop();
                feedbackLabel1.ForeColor = this.BackColor;
            }
        }

        private void updateFeedbackLabel(int errorCode)
        {
            switch (errorCode)
            {
                case 3:
                    feedbackLabel1.Text = "Name can't be empty!";
                    break;
                case 4:
                    feedbackLabel1.Text = "Surname can't be empty!";
                    break;
                case 5:
                    feedbackLabel1.Text = "Password can't be empty!";
                    break;
                case 6:
                    feedbackLabel1.Text = "Password doesn't match!";
                    break;
                case 7:
                    feedbackLabel1.Text = "Password must be at least 8 characters long\nwith at least one letter and one digit!";
                    break;
                case 8:
                    feedbackLabel1.Text = "Connection error please try again!";
                    break;
            }
        }

		private void ProfileForm_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
							this.DisplayRectangle);
		}
        
        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            int rowsAffected = DBConnect.Delete(Account);
            this.st.Logout();
            this.Close();
            MessageBox.Show("  Your profile deleted successfully!");
        }

        private void clearPhotoButton_Click(object sender, EventArgs e)
		{
			imagePathTB.Text = "";
			imagePB.Image = Properties.Resources.default_avatar;
		}
        #endregion
    }
}
