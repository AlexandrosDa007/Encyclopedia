using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Encyclopedia.Model;
using UI;
using Encyclopedia.Controller;

namespace Encyclopedia.View
{
    /// <summary>
    /// A User Control to display the edited Lemmas of the User
    /// </summary>
    public partial class EditedLemmataUserControl : UserControl
    {
        #region Properties
        public List<EditedLemma> EditedLemmas { set; get; }
        #endregion

        #region Constructors
        public EditedLemmataUserControl()
        {
            InitializeComponent();
            
        }
        #endregion

        /// <summary>
        /// A reference to the static Instance of this Control
        /// </summary>
        private static EditedLemmataUserControl _instance;

        /// <summary>
        /// A reference to the public Instance of this Control
        /// </summary>
        public static EditedLemmataUserControl Instance
        {
            get
            {

                if (_instance == null)
                    _instance = new EditedLemmataUserControl();
                return _instance;

            }
        }

        #region Private methods
        private Label setLabelData(string labelString, bool isRemoveLabel)
        {
            Font style = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));      
            Label newLabel = new Label();
            if (isRemoveLabel)
                newLabel.ForeColor = Color.Orange;
            
            newLabel.Text = labelString;
            newLabel.Font = style;
            newLabel.Dock = DockStyle.Fill;
            newLabel.TextAlign = ContentAlignment.MiddleCenter;

            return newLabel;
        }

        private void NewLabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion


        #region Public methods
        public void RemoveClick(object sender, EventArgs e)
        {
            int row = editedTableLayoutPanel.GetRow(((Label)sender));
            Label titleLabel = (Label)editedTableLayoutPanel.GetControlFromPosition(0, row);
            EditedLemma toBeRemoved = null;
            
            foreach (EditedLemma ed in EditedLemmas)
            {
                if (ed.LemmaTitle == titleLabel.Text)
                {
                    
                    toBeRemoved = ed;
                    break;
                }
            }
            int result = DBConnect.Delete(toBeRemoved, StartPage.account.User);
            if(result != 1)
            {
                MessageBox.Show("  Something went wrong trying to remove that Lemma.");
            }
            else
            {
                //now remove and update
                EditedLemmas.Remove(toBeRemoved);
                StartPage.editedLemmaList = EditedLemmas;
                SetLemmas();
            }

        }

        public void TitleClick(object sender, EventArgs e)
        {
            //send data to LemmaViewUserControl

            StartPage startP = (StartPage)this.Parent.Parent.Parent;
            
            LemmaViewUserControl.Instance.Dock = DockStyle.Fill;
            LemmaViewUserControl.Instance.BringToFront();
            LemmaViewUserControl.Instance.ChangeValue(((Label)sender).Text, 1);
            LemmaViewUserControl.Instance.IsFavorite = false;

        }

        public void SetLemmas()
        {
            editedTableLayoutPanel.Controls.Clear();
            int i = 0;
            if (EditedLemmas.Count < 3)
                editedTableLayoutPanel.RowCount = 3 + 1;
            else
                editedTableLayoutPanel.RowCount = EditedLemmas.Count + 1;
            foreach (EditedLemma e in EditedLemmas)
            {

                Label title = setLabelData(e.LemmaTitle, false);
                title.Click += new EventHandler(this.TitleClick);
                Label updatedAt = setLabelData(e.UpdatedAt.ToShortDateString(), false);
                updatedAt.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
                Label removeLabel = setLabelData("Remove", true);
                removeLabel.Click += new EventHandler(this.RemoveClick);

                editedTableLayoutPanel.Controls.Add(title, 0, i);
                editedTableLayoutPanel.Controls.Add(updatedAt, 1, i);
                editedTableLayoutPanel.Controls.Add(removeLabel, 2, i);
                i++;
            }

            editedTableLayoutPanel.Controls.Add(new Label() { Text = "" }, 0, i);
        }
        #endregion
    }
}
