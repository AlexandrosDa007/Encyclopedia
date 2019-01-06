using Encyclopedia.Controller;
using Encyclopedia.Model;
using Encyclopedia.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    public partial class StartPage : Form
    {
		// stores the account of the logged-in user
		public static Account account = null;

        //stores the recent lemmas of the guest or user
        public static List<string> recentLemmas = new List<string>();

		//a list with all the controls to be hidden when login is successfull
		public List<Control> controlsBeforeLogin = new List<Control>();
        //the new leftpanel 
        public AfterLoginUserControl afterLoginPanel;
        //a public variable to hold everything --- used instead of private Panel leftPanel
        public Panel newLeftPanel;

        //stores the edited Lemma of the user
        public static List<EditedLemma> editedLemmaList;
        //stores the favourite Lemma of the user
        public static List<FavoriteLemma> favoriteLemmaList;

		// stores the contacts of the logged-in user
		public static List<User> contactList = null;
		// stores the contact groups of the logged-in user
		public static List<string> groupList = null;

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
            mainPanel.Controls.Add(Encyclopedia.View.LemmaViewUserControl.Instance);

            //copy all the controls of private left panel to newLeftPanel
            newLeftPanel = leftPanel;
            //remove the private left panel
            this.Controls.Remove(leftPanel);
            //add the newLeftPanel
            this.Controls.Add(newLeftPanel);

			DynamicUIControlsHandler.FillCategories(filterCheckedListBox);
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

            SearchResultsUserControl.Instance.AddRecentLemmas();
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

        private void minimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //Take user input from fields
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            //crate a handler to validate user information -- returns true if user exists otherwise false
            LoginHandler handler = new LoginHandler(username, password);
            bool doesUserExist = handler.ValidateAccount();

            Console.WriteLine(doesUserExist);

            if (doesUserExist)
            {
				//User Exists
			    //get some static properties
				account = DBConnect.GetAccountByUsername(username);
                editedLemmaList = DBConnect.GetEditedLemmasByUser(account.User);
                favoriteLemmaList = DBConnect.GetFavoriteLemmasByUser(account.User);
				contactList = DBConnect.GetContacts(account.User.Id);
				groupList = DBConnect.GetContactGroups(account.User.Id);

				//set up edited lemmas and favorites Lemmas 
				EditedLemmataUserControl.Instance.editedLemmas = StartPage.editedLemmaList;
                EditedLemmataUserControl.Instance.SetLemmas();
                FavouriteLemmataUserControl.Instance.favoriteLemmas = StartPage.favoriteLemmaList;
                FavouriteLemmataUserControl.Instance.SetLemmas();

				// set up contacts and contact groups
				ContactsUserControl.Instance.contactList = StartPage.contactList;
				ContactsUserControl.Instance.groupList = StartPage.groupList;
				ContactsUserControl.Instance.UpdateTabControl();

				//show after login panel
				afterLoginPanel = new AfterLoginUserControl();
                afterLoginPanel.Account = account;
                afterLoginPanel.SetImage();
                changePanelControls();
                LemmaViewUserControl.Instance.ChangeLabelsToVisibleByValue(true);

            }
            else
            {
				//User doesnt Exists
				//change the feedback label -- just for demo
				feedbackLabel.Text = "Wrong username or password, please try again.";
				feedbackLabel.ForeColor = Color.White;

				Timer timer1 = new Timer();
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Start();
            }
            
        }

        private void changePanelControls()
        {

            foreach (Control x in newLeftPanel.Controls)
            {
                controlsBeforeLogin.Add(x);
                x.Visible = false;
            }

            leftPanel.Controls.Add(afterLoginPanel);
        }

        public void Logout()
        {

            foreach (Control x in controlsBeforeLogin)
            {
                x.Visible = true;
            }

            newLeftPanel.Controls.Remove(afterLoginPanel);
            LemmaViewUserControl.Instance.ChangeLabelsToVisibleByValue(false);

			usernameTextBox.Text = "";
			passwordTextBox.Text = "";
			feedbackLabel.Text = "";
        }

		private void StartPage_Paint(object sender, PaintEventArgs e)
		{
			
		}

		private void StartPage_Load(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.None;

			Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
			this.MaximumSize = new Size(workingRectangle.Width, workingRectangle.Height);
			this.WindowState = FormWindowState.Maximized;
		}

        

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Trim() != "" || searchTextBox.Text != null)

            {

                searchTextBox.Text = "";

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int fadingSpeed = 8;
            feedbackLabel.ForeColor = Color.FromArgb(feedbackLabel.ForeColor.R - fadingSpeed, feedbackLabel.ForeColor.G - fadingSpeed, feedbackLabel.ForeColor.B - fadingSpeed);
			
            if (feedbackLabel.ForeColor.B <= feedbackLabel.BackColor.B)
            {
                ((Timer)sender).Stop();
                feedbackLabel.ForeColor = feedbackLabel.BackColor;
            }
        }
    }
}