using System.Windows.Forms;
using UI;
using Encyclopedia.Controller;
using Encyclopedia.Model;

namespace Encyclopedia.View
{
    public partial class LemmaOfTheDayUserControl : UserControl
    {
        private static LemmaOfTheDayUserControl _instance;


        public static LemmaOfTheDayUserControl Instance
        {
            get
            {
                
                if (_instance == null)
                    _instance = new LemmaOfTheDayUserControl();
                return _instance;

            }
        }
        public LemmaOfTheDayUserControl()
        {
            //init the database connection -- not the best place here
            
            InitializeComponent();

            SetRandomLemma();
        }
		
		// Use this to Search
		public void SetRandomLemma()
		{
			// get a random lemma to display
			Lemma lemma = Random.getRandomLemma();
			
			// configure the web browser document text accordingly
			string titleStyle = " style=\"display: block; " +
				"font-size: 3em;" +
				"margin-top: 0.67em; " +
				"margin-bottom: 0.67em; " +
				"margin-left: 0; " +
				"margin-right: 0; " +
				"font-weight: bold;\"";
			lemmaOfTheDayWebBrowser.DocumentText = "<h1" + titleStyle + ">" + lemma.Title.Replace("_", " ") + "</h1>" + lemma.Body;
			if (!StartPage.recentLemmas.Contains(lemma.Title))
				StartPage.recentLemmas.Add(lemma.Title);
		}
    }
}
