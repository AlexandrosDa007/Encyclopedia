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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

			DynamicUIControlsHandler.FillEducationLevels(educationLevelCB);
			DynamicUIControlsHandler.FillRoles(roleCB);
        }

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
            if (imagePathTB.Text.Length > 0)
            {
                string filePath = imagePathTB.Text;
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                imageData = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();
            }
			string username = usernameTextBox.Text;
			string password = passwordTextBox.Text;
			string passwordConfirmation = passwordConfirmTextBox.Text;
			string email = emailTextBox.Text;

			// call the method to validate the input and complete the registration process
			// the exitCode must be equal to 0, otherwise something went wrong
			// the error range is | from 10 to 16 related to the User | from 20 to 27 related to the Account | 2 and 3 related to Database problem
            int exitCode = UserHandler.RegisterUserAccount(name, surname, dateOfBirth, gender, tel, roleName, educationLevelName, description, imageData, username, password, passwordConfirmation, email);

			// show error messages if any
			Console.WriteLine("The exit code was: " + exitCode);
            switch (exitCode)
            {
                case 2:
                    feedbackLabel.Text = "The exit code was: " + exitCode + " Something went wrong with the User insertion in the database - Database Problem!";
                    break;
                case 3:
                    feedbackLabel.Text = "The exit code was: " + exitCode + " Something went wrong with the Account insertion in the database - Database Problem!";
                    break;
                case 10:
                    feedbackLabel.Text = "The exit code was: " + exitCode + " Name isn't valid!";
                    break;
                case 11:
                    feedbackLabel.Text = "The exit code was: " + exitCode + " Surname isn't valid!";
                    break;
                case 12:
                    feedbackLabel.Text = "The exit code was: " + exitCode + " Date of birth isn't valid!";
                    break;
                case 13:
                    feedbackLabel.Text = "The exit code was: " + exitCode + " Gender isn't valid!";
                    break;
                case 14:
                    feedbackLabel.Text = "The exit code was: " + exitCode + " Telephone number isn't valid!";
                    break;
                case 15:
                    feedbackLabel.Text = "The exit code was: " + exitCode + " Description isn't valid!";
                    break;
                case 16:
                    feedbackLabel.Text = "The exit code was: " + exitCode + " Image isn't valid!";
                    break;
                case 20:
                    feedbackLabel.Text = "The exit code was: " + exitCode + " The inserted email is used before!";
                    break;
                case 21:
                    feedbackLabel.Text = "The exit code was: " + exitCode + " This username is already used, Try Again!";
                    break;
                case 22:
                    feedbackLabel.Text = "The exit code was: " + exitCode + " Password does not match the confirm password!";
                    break;
                case 23:
                    feedbackLabel.Text = "The exit code was: " + exitCode + " Password must contain at least 8 characters, one number and one letter";
                    break;
                case 24:
                    feedbackLabel.Text = "The exit code was: " + exitCode + " Username isn't valid!";
                    break;
                case 25:
                    feedbackLabel.Text = "The exit code was: " + exitCode;
                    break;
                case 26:
                    feedbackLabel.Text = "The exit code was: " + exitCode + " Email form can't be empty!";
                    break;
                case 27:
                    feedbackLabel.Text = "The exit code was: " + exitCode + " Invalid email address, wrong format!";
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
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Title = "Please select an image for your account.";

                // show only image file formats
                openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.PNG;*.GIF)|*.BMP;*.JPG;*.JPEG;*.PNG;*.GIF|All files (*.*)|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // check if the file size isn't bigger than 16 MB approx. (measured in bytes)
                    long imageLength = new FileInfo(openFileDialog1.FileName).Length;
                    if (imageLength > 1000000)
                    {
                        throw new ArgumentOutOfRangeException(nameof(imageLength));
                    }

                    imagePathTB.Text = openFileDialog1.FileName;
                    imagePB.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                // show the exception message in order to inform the user
                feedbackLabel.Text = "The chosen image size is too big. Please choose one up to 1MB.";
				feedbackLabel.ForeColor = Color.Black;

				// fade out effect in feedbackLabel message
				Timer timer1 = new Timer();
				timer1.Tick += new EventHandler(timer1_Tick);
				timer1.Start();
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
	}

    //private void updateFeedbackLabel(int errorCode)
    //{
    //    switch (exitCode)
    //    {
    //        case 3:
    //            feedbackLabel.Text = "*Name can't be empty!";
    //            break;
    //        case 4:
    //            feedbackLabel.Text = "*Surname can't be empty!";
    //            break;
    //        case 5:
    //            feedbackLabel.Text = "*Password can't be empty!";
    //            break;
    //        case 6:
    //            feedbackLabel.Text = "*Password doesn't match!";
    //            break;
    //        case 7:
    //            feedbackLabel.Text = "*Password must be at least 8 characters long\n with at least one letter and one digit!";
    //            break;
    //        case 8:
    //            feedbackLabel.Text = "*Connection error please try again!";
    //            break;
    //    }
}
