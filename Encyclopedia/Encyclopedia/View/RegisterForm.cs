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
            string name = nameTB.Text;
            string surname = surnameTB.Text;
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
            string tel = telTB.Text;
            string roleName = roleCB.GetItemText(roleCB.SelectedItem);
			string educationLevelName = educationLevelCB.GetItemText(educationLevelCB.SelectedItem);
            string description = descriptionRTB.Text;
            // convert the image into a Byte array
            Byte[] imageData = null;
            if (imagePathTB.Text.Length > 0)
            {
                string filePath = imagePathTB.Text;
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                imageData = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();
            }
			else
			{
				imageData = new byte[0];
			}
			string username = usernameTB.Text;
			string password = passwordTB.Text;
			string passwordConfirmation = passwordConfirmTB.Text;
			string email = emailTB.Text;

			Console.WriteLine(name + "  " + surname + " !!!" + tel + "!!! " + email + "   " + username + "    " + password + "  " + passwordConfirmation + "    " + gender + "  " + dateOfBirth + " >>>" + educationLevelName + "<<<  >>>" + roleName + "<<<    " + description);


			// call the method to validate the input and complete the registration process
			// the exitCode must be equal to 0, otherwise something went wrong
			// the error range is | from 10 to 19 related to the User | from 20 to 28 related to the Account | 2 and 3 related to Database problem
            int exitCode = UserHandler.RegisterUserAccount(name, surname, dateOfBirth, gender, tel, roleName, educationLevelName, description, imageData, username, password, passwordConfirmation, email);

			// show error messages if any
			Console.WriteLine("The exit code was: " + exitCode);
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
                    if (imageLength > 16250215)
                    {
                        throw new ArgumentOutOfRangeException(nameof(imageLength));
                    }

                    imagePathTB.Text = openFileDialog1.FileName;
                    imagePB.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // show the exception message in order to inform the user
                Console.WriteLine(ex.Message);
            }
        }
    }
}
