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
        public EditedLemma editedLemma;
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

        public LemmaEditor(EditedLemma editedLemma, int mode)
        {
            InitializeComponent();
            this.editedLemma = editedLemma;
            this.mode = mode;
            lemmaTitleLabel.Text = editedLemma.LemmaTitle + " - Edited By '" + StartPage.account.User.Name + "'";
        }



        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void revertButton_Click(object sender, EventArgs e)
        {
            if(mode == 0)
                htmlTextBox1.WebBrowser.Document.Body.InnerHtml = lemma.Body;
            else if(mode == 1)
            {
                htmlTextBox1.WebBrowser.Document.Body.InnerHtml = editedLemma.Body;
            }

        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            //Determine if we are creating a new edited Lemma or updating one
            byte[] newBody = Encoding.UTF8.GetBytes(htmlTextBox1.WebBrowser.Document.Body.InnerHtml);
            //if new one
            if (mode == 0)
            {
               
                //make EditedLemma
                editedLemma = new EditedLemma(lemma.Title, StartPage.account.User, newBody, DateTime.Now, DateTime.Now);

                int res = DBConnect.Insert(editedLemma);
                if (res == 1)
                {
                    MessageBox.Show("  The edited lemma \"" + lemma.Title + "\" was saved successfully to your account!\n");
                    StartPage.editedLemmaList = DBConnect.GetEditedLemmasByUser(StartPage.account.User);
                    EditedLemmataUserControl.Instance.editedLemmas = StartPage.editedLemmaList;
                    EditedLemmataUserControl.Instance.SetLemmas();
                    Close();
                }
                else
                {
                    MessageBox.Show("  Something went wrong! Please try again.\n");
                }
            }else if(mode == 1)
            {
                //if updating existing one
                editedLemma = DBConnect.GetEditedLemmaByUserAndTitle(editedLemma.LemmaTitle, StartPage.account.User);
                editedLemma.Body = htmlTextBox1.WebBrowser.Document.Body.InnerHtml;
                editedLemma.UpdatedAt = DateTime.Now;

                int res = DBConnect.Update(editedLemma, StartPage.account.User);
                if (res == 1)
                {
                    MessageBox.Show("  The edited lemma \"" + lemma.Title + "\" was saved successfully to your account!\n");
                    StartPage.editedLemmaList = DBConnect.GetEditedLemmasByUser(StartPage.account.User);
                    EditedLemmataUserControl.Instance.editedLemmas = StartPage.editedLemmaList;
                    EditedLemmataUserControl.Instance.SetLemmas();
                    Close();
                }
                else
                {
                    MessageBox.Show("  Something went wrong! Please try again.\n");
                }
            }


            
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
