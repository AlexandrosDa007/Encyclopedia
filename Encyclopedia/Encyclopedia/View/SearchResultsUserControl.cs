using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Encyclopedia.Controller;
using Lucene.Net.Documents;
using UI;
using Encyclopedia.Model;

namespace Encyclopedia.View
{
    /// <summary>
    /// A User Control that displays search results in a list view.
    /// That the User can click on to see the body.
    /// </summary>
    public partial class SearchResultsUserControl : UserControl
    {
        /// <summary>
        /// A static reference to the Instance of this User Control.
        /// </summary>
        private static SearchResultsUserControl _instance;

        /// <summary>
        /// A static reference to the public Instance of this Control.
        /// </summary>
        public static SearchResultsUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SearchResultsUserControl();
                return _instance;

            }
        }

        #region Constructors
        public SearchResultsUserControl()
        {
            InitializeComponent();

			ImageList list = new ImageList();
			list.ImageSize = new Size(8, 48);
			searchResultsListView.SmallImageList = list;
		}
        #endregion

        #region Private methods
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Get the selected item's text
            string toSearch = searchResultsListView.SelectedItems[0].Text;
            Encyclopedia.View.LemmaViewUserControl.Instance.Dock = DockStyle.Fill;
            Encyclopedia.View.LemmaViewUserControl.Instance.BringToFront();
            //search for the lemma_body


            //if user is connected
            if (StartPage.account != null)
            {
                LemmaViewUserControl.Instance.IsFavorite = false;
                foreach (FavoriteLemma f in StartPage.favoriteLemmaList)
                {
                    if (f.Title.Equals(toSearch))
                    {
                        LemmaViewUserControl.Instance.IsFavorite = true;
                        Encyclopedia.View.LemmaViewUserControl.Instance.ChangeValue(toSearch, 0);
                        return;
                    }
                    else
                    {
                        LemmaViewUserControl.Instance.IsFavorite = false;
                    }
                }
            }
            Encyclopedia.View.LemmaViewUserControl.Instance.ChangeValue(toSearch, 0);

        }
        #endregion

        #region Public methods
        public void AddRecentLemmata()
        {
            searchResultsListView.Items.Clear();

            StartPage.recentLemmata.Reverse();
            foreach(string title in StartPage.recentLemmata)
            {
                searchResultsListView.Items.Insert(searchResultsListView.Items.Count, title);
            }
            StartPage.recentLemmata.Reverse();
        }

		public void AddPopularLemmata()
		{
			searchResultsListView.Items.Clear();

			// get the 10 most popular lemmata
			List<string> popularLemmataTitles = DBConnect.GetPopularLemmata();

			foreach (string lemmaTitle in popularLemmataTitles)
			{
				// fill the searchResultsListView with the popular lemma titles
				searchResultsListView.Items.Add(lemmaTitle);
			}
		}

        public void AddToTheResults(string text, List<string> checkedFilters)
        {
            //clear the list
            searchResultsListView.Items.Clear();
            //make the search in the indexed file
            List<Document> list = Search.DoSearch(text);
            if (list == null)
                return;

            //if all filters are unchecked
            if(checkedFilters.Count == 0)
            {
                //iterate
                foreach (Document doc in list)
                {
                    Label l = new Label();
                    //add a new label with the value of titles matching the search text
                    searchResultsListView.Items.Add(doc.GetField("lemma_title").StringValue);
                }
            }
            else
            {
                /*
                 * Search the top results and filter them by all the filters that are checked
                 */

                List<Document> documents = new List<Document>();
                //get all id's of the filters
                List<int> filterIds = DBConnect.GetCategoryIdByName(checkedFilters);
                foreach (Document doc in list)
                {
                    foreach(int id in filterIds)
                    {
                        if (Convert.ToInt32(doc.GetField("category_id").StringValue) == id)
                        {
                            documents.Add(doc);
                        }
                    }
                    
                }
                //iterate
                foreach (Document doc in documents)
                {
                    Label l = new Label();
                    //add a new label with the value of titles matching the search text
                    searchResultsListView.Items.Add(doc.GetField("lemma_title").StringValue);
                }
            }
        }
        #endregion
    }
}
