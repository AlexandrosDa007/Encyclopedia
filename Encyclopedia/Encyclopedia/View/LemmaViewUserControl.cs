using System;
using System.Text;
using System.Windows.Forms;
using Encyclopedia.Controller;
using Encyclopedia.Model;
using mshtml;

namespace Encyclopedia.View
{
    public partial class LemmaViewUserControl : UserControl
    {
        public Lemma lemma;

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
            //init the database connection -- not the best place here

            InitializeComponent();
            //start by having something as default --TO BE CHANGED
            //ChangeValue("Concept");
            //SetLemmaData("Placebo");
            


        }

        public void SetLemmaData(string lemmaTitle)
        {
            byte[] body = DBConnect.GetLemmaBodyByTitle(lemmaTitle);
            int categoryId = DBConnect.GetLemmaCategoryByTitle(lemmaTitle);
            lemma = new Lemma(lemmaTitle, body, categoryId);
            
        }

        public void ChangeValue(string title)
        {
			string titleStyle = " style=\"display: block; " +
				"font-size: 3em;" +
				"margin-top: 0.67em; " +
				"margin-bottom: 0.67em; " +
				"margin-left: 0; " +
				"margin-right: 0; " +
				"font-weight: bold;\"";

            //change the web browser to display the lemma_body from the title given
            LemmaViewWebBrowser.DocumentText = "<h1" + titleStyle + ">" + title.Replace("_", " ") + "</h1>" + Encoding.UTF8.GetString(DBConnect.GetLemmaBodyByTitle(title));
        }

		private void savePictureBox_Click(object sender, EventArgs e)
		{
			try
			{
				SaveFileDialog savefile = new SaveFileDialog();
				// set a default file name
				savefile.FileName = "somelemmma";
				// set filters - this can be done in properties as well
				savefile.Filter = "Pdf Files|*.pdf";

				if (savefile.ShowDialog() == DialogResult.OK)
				{
					string path = savefile.FileName;
					string lemmaTitle = "American_Literature_(academic_discipline)";
					PDF.exportToPDF(lemmaTitle, path);
				}
			}
			catch (ArgumentOutOfRangeException ex)
			{
				// show the exception message in order to inform the user
				Console.WriteLine(ex.Message);
			}
		}

		private void printPictureBox_Click(object sender, EventArgs e)
		{
			// print the document currently displayed in the WebBrowser
			LemmaViewWebBrowser.Print();
		}

        private void editPictureBox_Click(object sender, EventArgs e)
        {

        }

        public void ChangeLabelsToVisibleByValue(bool value)
        {
            favouritesPictureBox.Visible = value;
            sharePictureBox.Visible = value;
            editPictureBox.Visible = value;
        }

    }
}
