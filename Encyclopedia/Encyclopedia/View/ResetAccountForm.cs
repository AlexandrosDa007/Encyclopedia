using System;
using System.Drawing;
using System.Windows.Forms;
using Encyclopedia.Controller;

namespace Encyclopedia.View
{
    /// <summary>
    /// A small window form for forgot password system.
    /// </summary>
    public partial class ResetAccountForm : Form
    {
        #region Constructors
        public ResetAccountForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Private methods
        private void ResetAccountForm_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
							this.DisplayRectangle);
		}

		private void resetButton_Click(object sender, EventArgs e)
		{
			string username = usernameTextBox.Text;
			string email = emailTextBox.Text;

			int exitCode = UserHandler.SendTempPasswordToAccountEmail(username, email);
			if (exitCode == 0)
			{
				DialogResult dialogResult = MessageBox.Show("  A temporary password was sent to your registered email!\n");
				if (dialogResult == DialogResult.OK)
				{
					closePictureBox_Click(this, new EventArgs());
				}
			}
			else if (exitCode == 1)
			{
				MessageBox.Show("  Please insert a username first (it should be at least two characters) and try again.\n");
			}
			else if (exitCode == 2)
			{
				MessageBox.Show("  Invalid email format. Please check for any mistakes and try again.\n");
			}
			else
			{
				MessageBox.Show("  Some of the fields entered was wrong. No account match found. Please try again.\n");
			}
		}

		private void closePictureBox_Click(object sender, EventArgs e)
		{
			this.Close();
		}
        #endregion
    }
}
