using Encyclopedia.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI;

namespace Encyclopedia.View
{
    public partial class LemmaEditor : Form
    {
        public Lemma lemma;

        public WebBrowser WebBrowser
        {
            get
            {
                return this.htmlTextBox1.WebBrowser;
            }
        }

        public LemmaEditor(Lemma lemma)
        {
            InitializeComponent();
            this.lemma = lemma;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void revertButton_Click(object sender, EventArgs e)
        {
            htmlTextBox1.WebBrowser.Document.Body.InnerHtml = lemma.Body;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            byte[] newBody = Encoding.UTF8.GetBytes(htmlTextBox1.WebBrowser.Document.Body.InnerHtml);
            Account account = StartPage.account;
            //make EditedLemma
            
            EditedLemma editedLemma = new EditedLemma(lemma,account.User,newBody,new DateTime().Date, new DateTime().Date);
            //TODO: insert to database - fix dateTime update
        }
    }
}
