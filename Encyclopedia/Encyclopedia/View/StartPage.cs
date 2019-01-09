using Encyclopedia.Controller;
using Encyclopedia.Model;
using Encyclopedia.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    /// <summary>
    /// The Form that appears when the application launches.
    /// This forms contains static variables as information about the User that is logged in
    /// </summary>
    public partial class StartPage : Form
    {
        #region Static members
        public static List<Lemma> allLemas = new List<Lemma>();
        // stores the account of the logged-in user
        public static Account account = null;
        //stores the recent lemmas of the guest or user
        public static List<string> recentLemmas = new List<string>();
        //stores the edited Lemma of the user
        public static List<EditedLemma> editedLemmaList;
        //stores the favourite Lemma of the user
        public static List<FavoriteLemma> favoriteLemmaList;
        // stores the contacts of the logged-in user
        public static List<User> contactList = null;
        // stores the contact groups of the logged-in user
        public static List<ContactGroup> groupList = null;
        #endregion

        #region Properties
        //a list with all the controls to be hidden when login is successfull
        public List<Control> ControlsBeforeLogin { set; get; }
        //the new leftpanel 
        public AfterLoginUserControl AfterLoginPanel { set; get; }
        //a public variable to hold everything --- used instead of private Panel leftPanel
        public Panel NewLeftPanel { set; get; }
        //list with filters to be checked
        public List<string> FilterList { set; get; }
        #endregion

        #region Constructors
        //Opens LemmaOfTheDayUserControl in mainPanel when application starts
        public StartPage()
        {
            ControlsBeforeLogin = new List<Control>();
            FilterList = new List<string>();
            InitializeComponent();
            if (!mainPanel.Controls.Contains(Encyclopedia.View.FeaturedLemmaUserControl.Instance))
            {
                mainPanel.Controls.Add(Encyclopedia.View.FeaturedLemmaUserControl.Instance);
                Encyclopedia.View.FeaturedLemmaUserControl.Instance.Dock = DockStyle.Fill;
                Encyclopedia.View.FeaturedLemmaUserControl.Instance.BringToFront();
            }
            else
            {
                Encyclopedia.View.FeaturedLemmaUserControl.Instance.BringToFront();
            }
            mainPanel.Controls.Add(Encyclopedia.View.LemmaViewUserControl.Instance);

            //copy all the controls of private left panel to newLeftPanel
            NewLeftPanel = leftPanel;
            //remove the private left panel
            this.Controls.Remove(leftPanel);
            //add the newLeftPanel
            this.Controls.Add(NewLeftPanel);

            DynamicUIControlsHandler.FillCategories(filterCheckedListBox);
        }
        #endregion

        #region Private methods
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

            SearchResultsUserControl.Instance.AddPopularLemmata();
        }

        //Opens LemmaOfTheDayUserControl in mainPanel when Logo is clicked
        private void logoLabel_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(Encyclopedia.View.FeaturedLemmaUserControl.Instance))
            {
                mainPanel.Controls.Add(Encyclopedia.View.FeaturedLemmaUserControl.Instance);
                Encyclopedia.View.FeaturedLemmaUserControl.Instance.Dock = DockStyle.Fill;
                Encyclopedia.View.FeaturedLemmaUserControl.Instance.BringToFront();
            }
            else
            {
                Encyclopedia.View.FeaturedLemmaUserControl.Instance.BringToFront();
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

        private void Search()
        {
            //add the the checked items to the filterlist
            foreach (Object ob in filterCheckedListBox.CheckedItems)
            {
                FilterList.Add(ob.ToString());
            }

            Encyclopedia.View.SearchResultsUserControl.Instance.AddToTheResults(searchTextBox.Text, FilterList);
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
            FilterList.Clear();
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
                EditedLemmataUserControl.Instance.EditedLemmas = StartPage.editedLemmaList;
                EditedLemmataUserControl.Instance.SetLemmas();
                FavouriteLemmataUserControl.Instance.FavoriteLemmas = StartPage.favoriteLemmaList;
                FavouriteLemmataUserControl.Instance.SetLemmas();

                // set up contacts and contact groups
                ContactsUserControl.Instance.ContactList = StartPage.contactList;
                ContactsUserControl.Instance.GroupList = StartPage.groupList;
                ContactsUserControl.Instance.UpdateTabControl();

                //show after login panel
                AfterLoginPanel = new AfterLoginUserControl();
                AfterLoginPanel.Account = account;
                AfterLoginPanel.SetImage();
                changePanelControls();
                LemmaViewUserControl.Instance.ChangeLabelsToVisibleByValue(true);
            }
            else
            {
                //User doesnt Exists
                feedbackLabel.Text = "Wrong username or password, please try again.";
                feedbackLabel.ForeColor = Color.White;

                Timer timer1 = new Timer();
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Start();
            }

        }

        private void changePanelControls()
        {

            foreach (Control x in NewLeftPanel.Controls)
            {
                ControlsBeforeLogin.Add(x);
                x.Visible = false;
            }

            leftPanel.Controls.Add(AfterLoginPanel);
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

        private void clearFilterButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < filterCheckedListBox.Items.Count; i++)
            {
                filterCheckedListBox.SetItemChecked(i, false);
            }
        }

        private void forgotPasswordLinkLabel_Click(object sender, EventArgs e)
        {
            ResetAccountForm resetForm = new ResetAccountForm();
            resetForm.ShowDialog();
        }
        #endregion

        #region Public methods
        public void Logout()
        {

            foreach (Control x in ControlsBeforeLogin)
            {
                x.Visible = true;
            }

            NewLeftPanel.Controls.Remove(AfterLoginPanel);
            LemmaViewUserControl.Instance.ChangeLabelsToVisibleByValue(false);

            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            feedbackLabel.Text = "";
        }
        #endregion
    }
}
