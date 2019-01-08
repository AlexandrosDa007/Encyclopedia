using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encyclopedia.Controller;

namespace Encyclopedia.View
{
    /// <summary>
    /// A Form that displays text boxes and controls so a new User can register.
    /// </summary>
    public partial class RegisterForm : Form
    {
        #region Constructors
        public RegisterForm()
        {
            InitializeComponent();

			DynamicUIControlsHandler.FillEducationLevels(educationLevelCB);
			DynamicUIControlsHandler.FillRoles(roleCB);
        }
        #endregion

        #region Private methods
        private void registerb_Click(object sender, EventArgs e)
        {
            // take all the input in variables
            string name = nameTextBox.Text;
            string surname = surnameTextBox.Text;
            DateTime dateOfBirth = dateOfBirthDTP.Value;
			char gender = '-';
            if (genderMaleRB.Checked)
            {
                gender = 'M';
            }
            else if (genderFemaleRB.Checked)
            {
                gender = 'F';
            }
            string tel = telTexBox.Text;
            string roleName = roleCB.GetItemText(roleCB.SelectedItem);
			string educationLevelName = educationLevelCB.GetItemText(educationLevelCB.SelectedItem);
            string description = descriptionRTB.Text;
            // convert the image into a Byte array
            byte[] imageData = null;

            if(imagePB.Image != null)
            {
                using (var ms = new MemoryStream())
                {
                    imagePB.Image.Save(ms, imagePB.Image.RawFormat);
                    imageData = ms.ToArray();
                }
            }
                
            string username = usernameTextBox.Text;
			string password = passwordTextBox.Text;
			string passwordConfirmation = passwordConfirmTextBox.Text;
			string email = emailTextBox.Text;

			// call the method to validate the input and complete the registration process
			// the exitCode must be equal to 0, otherwise something went wrong
			// the error range is | from 10 to 16 related to the User | from 20 to 27 related to the Account | 2 and 3 related to Database problem
            int exitCode = UserHandler.RegisterUserAccount(name, surname, dateOfBirth, gender, tel, roleName, educationLevelName, description, imageData, username, password, passwordConfirmation, email);
            if (exitCode == 0)
            {
                MessageBox.Show("  Registered Successfully!\n");
                Close();
            }
                
			// show error messages if any
			Console.WriteLine("The exit code was: " + exitCode);
            switch (exitCode)
            {
                case 2:
                    feedbackLabel.Text = "Something went wrong with the User insertion in the database - Database Problem!";
                    break;
                case 3:
                    feedbackLabel.Text = "Something went wrong with the Account insertion in the database - Database Problem!";
                    break;
                case 10:
                    feedbackLabel.Text = "Name isn't valid!";
                    break;
                case 11:
                    feedbackLabel.Text = "Surname isn't valid!";
                    break;
                case 12:
                    feedbackLabel.Text = "Date of birth isn't valid!";
                    break;
                case 13:
                    feedbackLabel.Text = "Gender isn't valid!";
                    break;
                case 14:
                    feedbackLabel.Text = "Telephone number isn't valid!";
                    break;
                case 15:
                    feedbackLabel.Text = "Description isn't valid!";
                    break;
                case 16:
                    feedbackLabel.Text = "Image isn't valid!";
                    break;
                case 20:
                    feedbackLabel.Text = "The inserted email is used before!";
                    break;
                case 21:
                    feedbackLabel.Text = "This username is already used, Try Again!";
                    break;
                case 22:
                    feedbackLabel.Text = "Password does not match the confirm password!";
                    break;
                case 23:
                    feedbackLabel.Text = "Password must contain at least 8 characters, one number and one letter";
                    break;
                case 24:
                    feedbackLabel.Text = "Username isn't valid!";
                    break;
                case 25:
                    feedbackLabel.Text = "The exit code was: " + exitCode;
                    break;
                case 26:
                    feedbackLabel.Text = "Email form can't be empty!";
                    break;
                case 27:
                    feedbackLabel.Text = "Invalid email address, wrong format!";
                    break;
            }
            feedbackLabel.ForeColor = Color.Black;

			// fade out effect in feedbackLabel message
			Timer timer1 = new Timer();
			timer1.Tick += new EventHandler(timer1_Tick);
			timer1.Start();
		}

        private void browseb_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Please select an image for your account.";

            // show only image file formats
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.PNG;*.GIF)|*.BMP;*.JPG;*.JPEG;*.PNG;*.GIF";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // check if the file size isn't bigger than 1 MB approx. (measured in bytes)
                long imageLength = new FileInfo(openFileDialog1.FileName).Length;
                if (imageLength > 1000000)
                {
                    MessageBox.Show("Please pick a smaller image!!");
                    return;
                }

                imagePB.Image = Image.FromFile(openFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("Please pick an image!");
                return;
            }


        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void timer1_Tick(object sender, EventArgs e)
		{
			int fadingSpeed = 5;
			feedbackLabel.ForeColor = Color.FromArgb(feedbackLabel.ForeColor.R + fadingSpeed, feedbackLabel.ForeColor.G + fadingSpeed, feedbackLabel.ForeColor.B + fadingSpeed);

			if (feedbackLabel.ForeColor.R >= this.BackColor.R)
			{
				((Timer)sender).Stop();
				feedbackLabel.ForeColor = this.BackColor;
			}
		}

		private void RegisterForm_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
							this.DisplayRectangle);
		}
        #endregion


    }
}
