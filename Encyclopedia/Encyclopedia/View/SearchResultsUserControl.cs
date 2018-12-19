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
        }

        public void AddToTheResults(string text, string[] filters)
        {
            //clear the list
            listView1.Items.Clear();
            //make the search in the indexed file
            List<Document> list = Search.DoSearch(text);
            if (list == null)
                return;

            //apply filter
            List<string> allLemmaTitlesToBeChecked = new List<string>();
            foreach (string str in filters)
            {
                List<string> lemma_titles = DBConnect.GetLemmaTitleByCategoryName(str);
                foreach(string title in lemma_titles)
                {
                    allLemmaTitlesToBeChecked.Add(title);
                }
            }

            Console.WriteLine("before it has: " + list.Count);

            List<Document> documentsToBeRemoved = new List<Document>();
            foreach(Document doc in list)
            {
                if (!allLemmaTitlesToBeChecked.Contains(doc.GetField("lemma_title").StringValue))
                    documentsToBeRemoved.Add(doc);
            }

            foreach(Document document in documentsToBeRemoved)
            {
                list.Remove(document);
            }

            Console.WriteLine("after it has: " + list.Count);

            //iterate
            foreach (Document doc in list)
            {
                Label l = new Label();
                //add a new label with the value of titles matching the search text
                listView1.Items.Add(doc.GetField("lemma_title").StringValue);
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Get the selected item's text
            string toSearch = listView1.SelectedItems[0].Text;
            //show The Home page
            Encyclopedia.View.LemmaOfTheDayUserControl.Instance.BringToFront();
            //search for the lemma_body
            Encyclopedia.View.LemmaOfTheDayUserControl.Instance.ChangeValue(toSearch);
        }
    }
}
