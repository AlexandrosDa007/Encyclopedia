using Encyclopedia.Controller;
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
        public int mode;

        public WebBrowser WebBrowser
        {
            get
            {
                return this.htmlTextBox1.WebBrowser;
            }
        }

        public LemmaEditor(Lemma lemma, int mode)
        {
            InitializeComponent();
            this.lemma = lemma;
            this.mode = mode;
            lemmaTitleLabel.Text = lemma.Title + " - Edited By '" + StartPage.account.User.Name + "'";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void revertButton_Click(object sender, EventArgs e)
        {
            htmlTextBox1.WebBrowser.Document.Body.InnerHtml = lemma.Body;
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            //Determine if we are creating a new edited Lemma or updating one
            
            //if new one
            if(mode == 0)
            {
                byte[] newBody = Encoding.UTF8.GetBytes(htmlTextBox1.WebBrowser.Document.Body.InnerHtml);
                Account account = StartPage.account;
                //make EditedLemma
                EditedLemma editedLemma = new EditedLemma(lemma.Title, account.User, newBody, DateTime.Now, DateTime.Now);

                int res = DBConnect.Insert(editedLemma);
                if (res == 1)
                {
                    MessageBox.Show("EditedLemma insert successfull!!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong!!");
                }
            }else if(mode == 1)
            {
                //if updating existing one
            }


            StartPage.editedLemmaList = DBConnect.GetEditedLemmasByUser(StartPage.account.User);
            EditedLemmataUserControl.Instance.editedLemmas = StartPage.editedLemmaList;
            EditedLemmataUserControl.Instance.SetLemmas();
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LemmaEditor_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
                            this.DisplayRectangle);
        }
    }
}
