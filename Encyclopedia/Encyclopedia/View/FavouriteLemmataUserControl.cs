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
    public partial class FavouriteLemmataUserControl : UserControl
    {
        public List<FavoriteLemma> favoriteLemmas;

        private static FavouriteLemmataUserControl _instance;



        public static FavouriteLemmataUserControl Instance
        {
            get
            {

                if (_instance == null)
                    _instance = new FavouriteLemmataUserControl();
                return _instance;

            }
        }
        public FavouriteLemmataUserControl()
        {
            InitializeComponent();
        }

        public void SetLemmas()
        {
            favoriteTableLayoutPanel.Controls.Clear();
            int i = 0;
            if (favoriteLemmas.Count < 3)
                favoriteTableLayoutPanel.RowCount = 3 + 1;
            else
                favoriteTableLayoutPanel.RowCount = favoriteLemmas.Count + 1;
            foreach (FavoriteLemma f in favoriteLemmas)
            {

                Label title = setLabelData(f.Title, false);
                title.Click += new EventHandler(this.titleClick);
                Label updatedAt = setLabelData(f.CreatedAt.ToShortDateString(), false);
                updatedAt.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
                Label removeLabel = setLabelData("Remove", true);
                removeLabel.Click += new EventHandler(this.removeClick);

                favoriteTableLayoutPanel.Controls.Add(title, 0, i);
                favoriteTableLayoutPanel.Controls.Add(updatedAt, 1, i);
                favoriteTableLayoutPanel.Controls.Add(removeLabel, 2, i);
                i++;
            }

            favoriteTableLayoutPanel.Controls.Add(new Label() { Text = "" }, 0, i);
        }

        private Label setLabelData(string labelString, bool isRemoveLabel)
        {
            Font style = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
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
            int row = favoriteTableLayoutPanel.GetRow(((Label)sender));
            Label titleLabel = (Label)favoriteTableLayoutPanel.GetControlFromPosition(0, row);
            FavoriteLemma toBeRemoved = null;
            foreach (FavoriteLemma f in favoriteLemmas)
            {
                if (f.Title == titleLabel.Text)
                {

                    toBeRemoved = f;
                    break;
                }
            }
            int result = DBConnect.Delete(toBeRemoved, StartPage.account.User);
            if (result != 1)
            {
                MessageBox.Show("Something went wrong with removing that Lemma");
            }
            else
            {
                //now remove and update
                favoriteLemmas.Remove(toBeRemoved);
                StartPage.favoriteLemmaList = favoriteLemmas;
                SetLemmas();
            }

        }

        public void titleClick(object sender, EventArgs e)
        {
            //send data to LemmaViewUserControl

            StartPage startP = (StartPage)this.Parent.Parent.Parent;

            LemmaViewUserControl.Instance.Dock = DockStyle.Fill;
            LemmaViewUserControl.Instance.BringToFront();
            //send mode = 0 so its treated as a raw lemma if we edit that it will go to editedLemmalist
            LemmaViewUserControl.Instance.isFavorite = true;
            LemmaViewUserControl.Instance.ChangeValue(((Label)sender).Text, 0);
            

        }


    }
}
