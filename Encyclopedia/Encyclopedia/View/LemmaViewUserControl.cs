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
    public partial class LemmaViewUserControl : UserControl
    {
        public Image favoriteClicked = Encyclopedia.Properties.Resources.favoriteClicked;
        public Image favoriteNotClicked = Encyclopedia.Properties.Resources.favoriteNotClicked;

        public Lemma lemma;
        public EditedLemma editedLemma;

        //private StartPage startPage;
        public int mode;

        public bool isFavorite;

        private static LemmaViewUserControl _instance;

        public static LemmaViewUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LemmaViewUserControl();
                return _instance;
            }
        }

        public LemmaViewUserControl()
        {
            InitializeComponent();
            //start by having something as default --TO BE CHANGED
            //ChangeValue("Concept");
            //SetLemmaData("Placebo");
        }

        public void SetLemmaData(string lemmaTitle,int mode)
        {
            if (mode == 0)
            {
                byte[] body = DBConnect.GetLemmaBodyByTitle(lemmaTitle);
                int categoryId = DBConnect.GetLemmaCategoryByTitle(lemmaTitle);
                lemma = new Lemma(lemmaTitle, body, categoryId);
            }
            else
            {
                editedLemma = DBConnect.GetEditedLemmaByUserAndTitle(lemmaTitle, StartPage.account.User);
            }
        }

        public void ChangeValue(string title, int mode)
        {
            if (isFavorite)
                favouritesButton.BackgroundImage = favoriteClicked;
            else
                favouritesButton.BackgroundImage = favoriteNotClicked;

            this.mode = mode;
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
                LemmaViewWebBrowser.DocumentText = "<h1" + titleStyle + ">" + title.Replace("_", " ") + "</h1>" + Encoding.UTF8.GetString(lemma.Body);
                if(!StartPage.recentLemmas.Contains(lemma.Title))
                    StartPage.recentLemmas.Add(lemma.Title);
            }
            else
            {
                LemmaViewWebBrowser.DocumentText = "<h1" + titleStyle + ">" + title.Replace("_", " ") + "</h1>" + editedLemma.Body;
                
            }
        }

        public void ChangeLabelsToVisibleByValue(bool value)
        {
            favouritesButton.Visible = value;
            shareButton.Visible = value;
            editButton.Visible = value;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            // print the document currently displayed in the WebBrowser
            LemmaViewWebBrowser.Print();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string lemmaTitle = lemma.Title;
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
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // show the exception message in order to inform the user
                Console.WriteLine(ex.Message);
            }
        }

        private void shareButton_Click(object sender, EventArgs e)
        {
			SendForm sendForm = new SendForm();
			sendForm.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if(mode == 0)
            {
                foreach(EditedLemma ed in StartPage.editedLemmaList)
                {
                    if (ed.LemmaTitle.Equals(lemma.Title))
                    {
                        MessageBox.Show("You already edited this lemma\nCheck your Edited Lemma Tab!");
                        return;
                    }
                }
            }
            else if(mode == 1)
            {
                foreach (EditedLemma ed in StartPage.editedLemmaList)
                {
                    if (ed.LemmaTitle.Equals(editedLemma.LemmaTitle))
                    {
                        LemmaEditor lemmaEditor = new LemmaEditor(editedLemma, mode);
                        lemmaEditor.ShowDialog();
                        return;
                    }
                }
            }

            //take input from html
            string lemmaBody = LemmaViewWebBrowser.Document.Body.InnerHtml;
            //if creating a new Lemma or updating one
            //0 new | 1 updating existing
            if(mode == 0)
            {
                LemmaEditor lemmaEditor = new LemmaEditor(lemma, mode);
                lemmaEditor.ShowDialog();
            }
            else if(mode == 1)
            {
                LemmaEditor lemmaEditor = new LemmaEditor(editedLemma, mode);
                lemmaEditor.ShowDialog();
            }
        }

        private void favouritesButton_Click(object sender, EventArgs e)
        {
            if (isFavorite)
            {
                foreach(FavoriteLemma f in StartPage.favoriteLemmaList)
                {
                    if (f.Title.Equals(lemma.Title))
                    {
                        int result = DBConnect.Delete(f, StartPage.account.User);
                        if (result != 1)
                        {
                            MessageBox.Show("Something went wrong with removing that Lemma");
                        }
                        else
                        {
                            //now remove and update
                            FavouriteLemmataUserControl.Instance.favoriteLemmas.Remove(f);
                            StartPage.favoriteLemmaList = FavouriteLemmataUserControl.Instance.favoriteLemmas;
                            FavouriteLemmataUserControl.Instance.SetLemmas();
                            isFavorite = false;
                            favouritesButton.BackgroundImage = favoriteNotClicked;
                            Console.WriteLine("Egine");
                        } 
                        return;
                    }
                }
            }

            if (mode == 0)
            {
                Favorite.addToFavorites(StartPage.account.User.Id, lemma.Title);
                isFavorite = true;
                favouritesButton.BackgroundImage = favoriteClicked;

            }
            else
                MessageBox.Show("You can't add a Lemma you edited in your favorites!");
        }
    }
}
