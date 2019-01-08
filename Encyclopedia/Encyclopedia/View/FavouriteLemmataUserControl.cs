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
    /// <summary>
    /// A User Control that displays the User's Favorite Lemmata
    /// </summary>
    public partial class FavouriteLemmataUserControl : UserControl
    {
        #region Properties
        public List<FavoriteLemma> FavoriteLemmas { set; get; }
        #endregion

        /// <summary>
        /// A static reference to the Instance of this User Control
        /// </summary>
        private static FavouriteLemmataUserControl _instance;


        /// <summary>
        /// A reference to the public Instance of the User Control
        /// </summary>
        public static FavouriteLemmataUserControl Instance
        {
            get
            {

                if (_instance == null)
                    _instance = new FavouriteLemmataUserControl();
                return _instance;

            }
        }

        #region Constructors
        public FavouriteLemmataUserControl()
        {
            InitializeComponent();
        }
        #endregion

        #region Private methods
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
        #endregion

        #region Public methods
        public void SetLemmas()
        {
            favoriteTableLayoutPanel.Controls.Clear();
            int i = 0;
            if (FavoriteLemmas.Count < 3)
                favoriteTableLayoutPanel.RowCount = 3 + 1;
            else
                favoriteTableLayoutPanel.RowCount = FavoriteLemmas.Count + 1;
            foreach (FavoriteLemma f in FavoriteLemmas)
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

        public void removeClick(object sender, EventArgs e)
        {
            int row = favoriteTableLayoutPanel.GetRow(((Label)sender));
            Label titleLabel = (Label)favoriteTableLayoutPanel.GetControlFromPosition(0, row);
            FavoriteLemma toBeRemoved = null;
            foreach (FavoriteLemma f in FavoriteLemmas)
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
                FavoriteLemmas.Remove(toBeRemoved);
                StartPage.favoriteLemmaList = FavoriteLemmas;
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
            LemmaViewUserControl.Instance.IsFavorite = true;
            LemmaViewUserControl.Instance.ChangeValue(((Label)sender).Text, 0);
            

        }
        #endregion

    }
}
