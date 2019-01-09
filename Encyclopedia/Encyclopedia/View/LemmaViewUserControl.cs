using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Encyclopedia.Controller;
using Encyclopedia.Model;
using mshtml;
using UI;

namespace Encyclopedia.View
{
    /// <summary>
    /// A User Control that displays any Lemma.
    /// </summary>
    public partial class LemmaViewUserControl : UserControl
    {
        /// <summary>
        /// Images from resources.
        /// </summary>
        public Image favoriteClicked = Encyclopedia.Properties.Resources.favoriteClicked;
        public Image favoriteNotClicked = Encyclopedia.Properties.Resources.favoriteNotClicked;

        #region Properties
        public Lemma Lemma { set; get; }
        public EditedLemma EditedLemma { set; get; }
        public int Mode { set; get; }
        public bool IsFavorite { set; get; }
        #endregion

        /// <summary>
        /// A static reference to the Instance of User Control
        /// </summary>
        private static LemmaViewUserControl _instance;

        /// <summary>
        /// A static reference of the public Instance of this Control
        /// </summary>
        public static LemmaViewUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LemmaViewUserControl();
                return _instance;
            }
        }


        #region Constructors
        public LemmaViewUserControl()
        {
            InitializeComponent();
        }
        #endregion

        #region Private methods
        private void printButton_Click(object sender, EventArgs e)
        {
            // print the document currently displayed in the WebBrowser
            LemmaViewWebBrowser.Print();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string lemmaTitle = Lemma.Title;
            try
            {
                SaveFileDialog savefile = new SaveFileDialog();
                // set a default file name
                savefile.FileName = lemmaTitle;
                // set filters - this can be done in properties as well
                savefile.Filter = "Pdf Files|*.pdf";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    string path = savefile.FileName;
                    PDF.exportToPDF(lemmaTitle, path);
                    MessageBox.Show("  PDF saved succesfully!\n");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // show the exception message in order to inform the user
                MessageBox.Show("  There was a problem on saving the PDF.\n");
            }
        }

        private void shareButton_Click(object sender, EventArgs e)
        {
            SendForm sendForm = new SendForm();
            sendForm.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (Mode == 0)
            {
                foreach (EditedLemma ed in StartPage.editedLemmaList)
                {
                    if (ed.LemmaTitle.Equals(Lemma.Title))
                    {
                        MessageBox.Show("  You already edited this lemma.\n  Check your Edited Lemma Tab!");
                        return;
                    }
                }
            }
            else if (Mode == 1)
            {
                foreach (EditedLemma ed in StartPage.editedLemmaList)
                {
                    if (ed.LemmaTitle.Equals(EditedLemma.LemmaTitle))
                    {
                        LemmaEditor lemmaEditor = new LemmaEditor(EditedLemma, Mode);
                        lemmaEditor.ShowDialog();
                        return;
                    }
                }
            }

            //take input from html
            string lemmaBody = LemmaViewWebBrowser.Document.Body.InnerHtml;
            //if creating a new Lemma or updating one
            //0 new | 1 updating existing
            if (Mode == 0)
            {
                LemmaEditor lemmaEditor = new LemmaEditor(Lemma, Mode);
                lemmaEditor.ShowDialog();
            }
            else if (Mode == 1)
            {
                LemmaEditor lemmaEditor = new LemmaEditor(EditedLemma, Mode);
                lemmaEditor.ShowDialog();
            }
        }

        private void favouritesButton_Click(object sender, EventArgs e)
        {
            if (IsFavorite)
            {
                foreach (FavoriteLemma f in StartPage.favoriteLemmaList)
                {
                    if (f.Title.Equals(Lemma.Title))
                    {
                        int result = DBConnect.Delete(f, StartPage.account.User);
                        if (result != 1)
                        {
                            MessageBox.Show("  Something went wrong trying to remove that Lemma.");
                        }
                        else
                        {
                            //now remove and update
                            FavouriteLemmataUserControl.Instance.FavoriteLemmas.Remove(f);
                            StartPage.favoriteLemmaList = FavouriteLemmataUserControl.Instance.FavoriteLemmas;
                            FavouriteLemmataUserControl.Instance.SetLemmas();
                            IsFavorite = false;
                            favouritesButton.BackgroundImage = favoriteNotClicked;
                        }
                        return;
                    }
                }
            }

            if (Mode == 0)
            {
                Favorite.addToFavorites(StartPage.account.User.Id, Lemma.Title);
                IsFavorite = true;
                favouritesButton.BackgroundImage = favoriteClicked;
            }
            else
                MessageBox.Show("  You can't add a Lemma you edited in your favorites!");
        }
        #endregion

        #region Public methods
        public void SetLemmaData(string lemmaTitle,int mode)
        {
            if (mode == 0)
            {
                byte[] body = DBConnect.GetLemmaBodyByTitle(lemmaTitle);
                int categoryId = DBConnect.GetLemmaCategoryByTitle(lemmaTitle);
                Lemma = new Lemma(lemmaTitle, body, categoryId);
            }
            else
            {
                EditedLemma = DBConnect.GetEditedLemmaByUserAndTitle(lemmaTitle, StartPage.account.User);
            }
        }

        public void ChangeValue(string title, int mode)
        {
            if (IsFavorite)
                favouritesButton.BackgroundImage = favoriteClicked;
            else
                favouritesButton.BackgroundImage = favoriteNotClicked;

            this.Mode = mode;
            SetLemmaData(title, mode);

			string titleStyle = " style=\"display: block; " +
				"font-size: 3em;" +
				"margin-top: 0.67em; " +
				"margin-bottom: 0.67em; " +
				"margin-left: 0; " +
				"margin-right: 0; " +
				"font-weight: bold;\"";

            //change the web browser to display the lemma_body from the title given
            if (mode == 0)
            {
                LemmaViewWebBrowser.DocumentText = "<h1" + titleStyle + ">" + title.Replace("_", " ") + "</h1>" + Encoding.UTF8.GetString(Lemma.Body);
                if(!StartPage.recentLemmata.Contains(Lemma.Title))
                    StartPage.recentLemmata.Add(Lemma.Title);
            }
            else
            {
                LemmaViewWebBrowser.DocumentText = "<h1" + titleStyle + ">" + title.Replace("_", " ") + "</h1>" + EditedLemma.Body;
            }
        }

        public void ChangeLabelsToVisibleByValue(bool value)
        {
            favouritesButton.Visible = value;
            shareButton.Visible = value;
            editButton.Visible = value;
        }
        #endregion

    }
}
