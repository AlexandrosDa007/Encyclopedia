using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encyclopedia.Model;
using UI;
using Encyclopedia.Controller;

namespace Encyclopedia.View
{
    public partial class EditedLemmataUserControl : UserControl
    {
        public List<EditedLemma> editedLemmas;

        public EditedLemmataUserControl()
        {
            InitializeComponent();
            
        }

        private static EditedLemmataUserControl _instance;


        public static EditedLemmataUserControl Instance
        {
            get
            {

                if (_instance == null)
                    _instance = new EditedLemmataUserControl();
                return _instance;

            }
        }

        public void SetLemmas()
        {
            editedTableLayoutPanel.Controls.Clear();
            int i = 0;
            editedTableLayoutPanel.RowCount = editedLemmas.Count;
            Console.WriteLine("Row:" + editedTableLayoutPanel.RowCount);
            foreach(EditedLemma e in editedLemmas)
            {

                Label title = setLabelData(e.LemmaTitle,false);
                title.Click += new EventHandler(this.titleClick);
                Label updatedAt = setLabelData(e.UpdatedAt.ToShortDateString(),false);
                updatedAt.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
                Label removeLabel = setLabelData("Remove", true);
                removeLabel.Click += new EventHandler(this.removeClick);

                editedTableLayoutPanel.Controls.Add(title,0,i);
                editedTableLayoutPanel.Controls.Add(updatedAt,1,i);
                editedTableLayoutPanel.Controls.Add(removeLabel, 2, i);
                i++;
            }
            
        }

        private Label setLabelData(string labelString, bool isRemoveLabel)
        {
            Font style = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));      
            Label newLabel = new Label();
            if (isRemoveLabel)
                newLabel.ForeColor = Color.Orange;
            
                
            newLabel.Text = labelString;
            newLabel.Font = style;
            newLabel.Dock = DockStyle.Fill;
            newLabel.TextAlign = ContentAlignment.MiddleCenter;

            return newLabel;
        }

        public void removeClick(object sender, EventArgs e)
        {
            Console.WriteLine("removing");
            int row = editedTableLayoutPanel.GetRow(((Label)sender));
            Label titleLabel = (Label)editedTableLayoutPanel.GetControlFromPosition(0, row);
            EditedLemma toBeRemoved = null;
            Console.WriteLine(titleLabel.Text);
            foreach (EditedLemma ed in editedLemmas)
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
                MessageBox.Show("Something went wrong with removing that Lemma");
            }
            else
            {
                //now remove and update
                editedLemmas.Remove(toBeRemoved);
                SetLemmas();
            }

        }

        public void titleClick(object sender, EventArgs e)
        {
            //send data to LemmaViewUserControl

            Console.WriteLine("Title is: " + ((Label)sender).Text);
            StartPage startP = (StartPage)this.Parent.Parent.Parent;
            
            LemmaViewUserControl.Instance.Dock = DockStyle.Fill;
            LemmaViewUserControl.Instance.BringToFront();
            LemmaViewUserControl.Instance.ChangeValue(((Label)sender).Text, LemmaViewUserControl.Mode.EditedLemma);

        }


        private void NewLabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
