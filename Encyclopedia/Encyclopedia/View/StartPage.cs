using Encyclopedia.View;
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
        //list with filters to be checked
        public List<string> filterList = new List<string>();

        //Opens LemmaOfTheDayUserControl in mainPanel when application starts
        public StartPage()
        {
            InitializeComponent();
            if (!mainPanel.Controls.Contains(Encyclopedia.View.LemmaOfTheDayUserControl.Instance))
            {
                mainPanel.Controls.Add(Encyclopedia.View.LemmaOfTheDayUserControl.Instance);
                Encyclopedia.View.LemmaOfTheDayUserControl.Instance.Dock = DockStyle.Fill;
                Encyclopedia.View.LemmaOfTheDayUserControl.Instance.BringToFront();
                
            }
            else
            {
                Encyclopedia.View.LemmaOfTheDayUserControl.Instance.BringToFront();   
            }     
        }

        //Opens SearchResultsUserControl in mainPanel when popularButton is clicked
        private void popularButton_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(Encyclopedia.View.SearchResultsUserControl.Instance))
            {
                mainPanel.Controls.Add(Encyclopedia.View.SearchResultsUserControl.Instance);
                Encyclopedia.View.SearchResultsUserControl.Instance.Dock = DockStyle.Fill;
                Encyclopedia.View.SearchResultsUserControl.Instance.BringToFront();

            }
            else
                Encyclopedia.View.SearchResultsUserControl.Instance.BringToFront();
        }

        //Opens LemmaOfTheDayUserControl in mainPanel when Logo is clicked
        private void logoLabel_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(Encyclopedia.View.LemmaOfTheDayUserControl.Instance))
            {
                mainPanel.Controls.Add(Encyclopedia.View.LemmaOfTheDayUserControl.Instance);
                Encyclopedia.View.LemmaOfTheDayUserControl.Instance.Dock = DockStyle.Fill;
                Encyclopedia.View.LemmaOfTheDayUserControl.Instance.BringToFront();
                
            }
            else
            {
                Encyclopedia.View.LemmaOfTheDayUserControl.Instance.BringToFront();
                
            }
                

        }

        //Opens SearchResultsUserControl in mainPanel when recentButton is clicked
        private void recentButton_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(Encyclopedia.View.SearchResultsUserControl.Instance))
            {
                mainPanel.Controls.Add(Encyclopedia.View.SearchResultsUserControl.Instance);
                Encyclopedia.View.SearchResultsUserControl.Instance.Dock = DockStyle.Fill;
                Encyclopedia.View.SearchResultsUserControl.Instance.BringToFront();

            }
            else
                Encyclopedia.View.SearchResultsUserControl.Instance.BringToFront();
        }
        /*
        private void filterCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(Encyclopedia.View.SearchResultsUserControl.Instance))
            {
                mainPanel.Controls.Add(Encyclopedia.View.SearchResultsUserControl.Instance);
                Encyclopedia.View.SearchResultsUserControl.Instance.Dock = DockStyle.Fill;
                Encyclopedia.View.SearchResultsUserControl.Instance.BringToFront();

            }
            else
                Encyclopedia.View.SearchResultsUserControl.Instance.BringToFront();
        }
        */
        /*
        private void searchTextbox_OnTextChange(object sender, EventArgs e)
        {
            
            if (!mainPanel.Controls.Contains(Encyclopedia.View.SearchResultsUserControl.Instance))
            {
                mainPanel.Controls.Add(Encyclopedia.View.SearchResultsUserControl.Instance);
                Encyclopedia.View.SearchResultsUserControl.Instance.Dock = DockStyle.Fill;
                Encyclopedia.View.SearchResultsUserControl.Instance.BringToFront();
                Search();

            }
            else
            {
                Encyclopedia.View.SearchResultsUserControl.Instance.BringToFront();
                Search();
                
            }
                
        }
        */
        private void Search()
        {
            //add the the checked items to the filterlist
            foreach (Object ob in filterCheckedListBox.CheckedItems)
            {
                filterList.Add(ob.ToString());
            }

            Encyclopedia.View.SearchResultsUserControl.Instance.AddToTheResults(searchTextBox.Text, filterList);

        }


        //Opens SearchResultsUserControl in mainPanel when we choose a date
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(Encyclopedia.View.SearchResultsUserControl.Instance))
            {
                mainPanel.Controls.Add(Encyclopedia.View.SearchResultsUserControl.Instance);
                Encyclopedia.View.SearchResultsUserControl.Instance.Dock = DockStyle.Fill;
                Encyclopedia.View.SearchResultsUserControl.Instance.BringToFront();

            }
            else
                Encyclopedia.View.SearchResultsUserControl.Instance.BringToFront();
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(Encyclopedia.View.SearchResultsUserControl.Instance))
            {
                mainPanel.Controls.Add(Encyclopedia.View.SearchResultsUserControl.Instance);
                Encyclopedia.View.SearchResultsUserControl.Instance.Dock = DockStyle.Fill;
                Encyclopedia.View.SearchResultsUserControl.Instance.BringToFront();

            }
            else
                Encyclopedia.View.SearchResultsUserControl.Instance.BringToFront();

            Search();
            //clear the filter list
            filterList.Clear();
        }

        private void newUserLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}