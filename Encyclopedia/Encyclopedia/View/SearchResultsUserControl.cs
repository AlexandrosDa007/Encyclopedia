using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encyclopedia.Controller;
using Lucene.Net.Documents;
using UI;

namespace Encyclopedia.View
{
    public partial class SearchResultsUserControl : UserControl
    {
        private static SearchResultsUserControl _instance;

        public static SearchResultsUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SearchResultsUserControl();
                return _instance;

            }
        }
        public SearchResultsUserControl()
        {
            InitializeComponent();

			ImageList list = new ImageList();
			list.ImageSize = new Size(8, 48);
			searchResultsListView.SmallImageList = list;
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

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Get the selected item's text
            string toSearch = searchResultsListView.SelectedItems[0].Text;
            Encyclopedia.View.LemmaViewUserControl.Instance.Dock = DockStyle.Fill;
            Encyclopedia.View.LemmaViewUserControl.Instance.BringToFront();
            //search for the lemma_body
            Encyclopedia.View.LemmaViewUserControl.Instance.ChangeValue(toSearch, LemmaViewUserControl.Mode.RawLemma);
        }

        
    }
}
