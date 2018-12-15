using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class StartPage : Form
    { 

        public StartPage()
        {
            InitializeComponent();
            lemmaOfTheDayPanel.Visible = true;

        }

        private void searchPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoLabel_Click(object sender, EventArgs e)
        {

        }

        private void logoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void connectUserLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }


        private void dateFilterLabel_Click(object sender, EventArgs e)
        {

        }

        private void popularButton_Click(object sender, EventArgs e)
        {
            searchResultsPanel.Visible = true;
            lemmaOfTheDayPanel.Visible = false;
        }

        
    }
}
