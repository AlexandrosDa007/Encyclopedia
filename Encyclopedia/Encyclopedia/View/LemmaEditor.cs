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
    /// <summary>
    /// A Form that allows the User to Edit a Lemma in a special Editor Using the HTMLTextBox User Control
    /// Credit to - https://www.codeproject.com/Articles/17307/HTMLTextBox
    /// </summary>
    public partial class LemmaEditor : Form
    {
        #region Properties
        public Lemma Lemma { set; get; }
        public EditedLemma EditedLemma { set; get; }
        public int Mode { set; get; }
        public WebBrowser WebBrowser
        {
            get
            {
                return this.htmlTextBox1.WebBrowser;
            }
        }
        #endregion

        #region Constructors
        public LemmaEditor(Lemma lemma, int mode)
        {
            InitializeComponent();
            this.Lemma = lemma;
            this.Mode = mode;
            lemmaTitleLabel.Text = lemma.Title + " - Edited By '" + StartPage.account.User.Name + "'";
        }

        public LemmaEditor(EditedLemma editedLemma, int mode)
        {
            InitializeComponent();
            this.EditedLemma = editedLemma;
            this.Mode = mode;
            lemmaTitleLabel.Text = editedLemma.LemmaTitle + " - Edited By '" + StartPage.account.User.Name + "'";
        }
        #endregion

        #region Private methods
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void revertButton_Click(object sender, EventArgs e)
        {
            if(Mode == 0)
                htmlTextBox1.WebBrowser.Document.Body.InnerHtml = Encoding.UTF8.GetString(Lemma.Body);
            else if(Mode == 1)
            {
                htmlTextBox1.WebBrowser.Document.Body.InnerHtml = EditedLemma.Body;
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Determine if we are creating a new edited Lemma or updating one
            byte[] newBody = Encoding.UTF8.GetBytes(htmlTextBox1.WebBrowser.Document.Body.InnerHtml);
            //if new one
            if (Mode == 0)
            {
               
                //make EditedLemma
                EditedLemma = new EditedLemma(Lemma.Title, StartPage.account.User, newBody, DateTime.Now, DateTime.Now);

                int res = DBConnect.Insert(EditedLemma);
                if (res == 1)
                {
                    MessageBox.Show("  The edited lemma \"" + Lemma.Title + "\" was saved successfully to your account!\n");
                    StartPage.editedLemmaList = DBConnect.GetEditedLemmasByUser(StartPage.account.User);
                    EditedLemmataUserControl.Instance.EditedLemmas = StartPage.editedLemmaList;
                    EditedLemmataUserControl.Instance.SetLemmas();
                    Close();
                }
                else
                {
                    MessageBox.Show("  Something went wrong! Please try again.\n");
                }
            }else if(Mode == 1)
            {
                //if updating existing one
                EditedLemma = DBConnect.GetEditedLemmaByUserAndTitle(EditedLemma.LemmaTitle, StartPage.account.User);
                EditedLemma.Body = htmlTextBox1.WebBrowser.Document.Body.InnerHtml;
                EditedLemma.UpdatedAt = DateTime.Now;

                int res = DBConnect.Update(EditedLemma, StartPage.account.User);
                if (res == 1)
                {
                    MessageBox.Show("  The edited lemma \"" + EditedLemma.LemmaTitle + "\" was saved successfully to your account!\n");
                    StartPage.editedLemmaList = DBConnect.GetEditedLemmasByUser(StartPage.account.User);
                    EditedLemmataUserControl.Instance.EditedLemmas = StartPage.editedLemmaList;
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

        private void htmlTextBox1_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
