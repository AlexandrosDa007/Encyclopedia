using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI;
using Encyclopedia.Controller;

namespace Encyclopedia.View
{
    public partial class LemmaOfTheDayUserControl : UserControl
    {
        private static LemmaOfTheDayUserControl _instance;


        public static LemmaOfTheDayUserControl Instance
        {
            get
            {
                
                if (_instance == null)
                    _instance = new LemmaOfTheDayUserControl();
                return _instance;

            }
        }
        public LemmaOfTheDayUserControl()
        {
            //init the database connection -- not the best place here
            
            InitializeComponent();
            //start by having something as default --TO BE CHANGED
            //ChangeValue("Concept");
        }


       ////Use this to Search
       // public void ChangeValue(string title)
       // {
       //     //change the web browser to display the lemma_body from the title given
       //     //lemmaOfTheDayWebBrowser.DocumentText = Encoding.UTF8.GetString(DBConnect.GetLemmaBodyByTitle(title));
       // }
    }
}
