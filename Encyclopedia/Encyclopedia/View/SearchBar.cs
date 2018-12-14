using Encyclopedia.Controller;
using Lucene.Net.Documents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encyclopedia.View
{
    public partial class SearchBar : Form
    {
        public List<Document> list;

        public SearchBar()
        {
            InitializeComponent();
            Search.CreateIndex();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            resultsList.Items.Clear();
            list = Search.DoSearch(searchBarText.Text);

            foreach(Document doc in list)
            {
                resultsList.Items.Add(doc.GetField("lemma_title").StringValue);
            }
            
        }

        private void resultsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.resultsList.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                textArea.Text = list[index].GetField("lemma_body").StringValue;
                webBrowser1.DocumentText = list[index].GetField("lemma_body").StringValue;
            }
        }
    }
}
