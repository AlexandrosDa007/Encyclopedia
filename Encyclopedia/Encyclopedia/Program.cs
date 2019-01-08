using Encyclopedia.Controller;
using Encyclopedia.Model;
using Encyclopedia.View;
using Lucene.Net.Analysis;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI;

namespace Encyclopedia
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //comment because database issues
            if (!DBConnect.Initialize())
            {
                MessageBox.Show("There was a problem with the server.\nPlease make sure you are connected to the internet!\nTry again");
                return;
            }


            
            //this takes a long time - 4min 
            //Search.CreateIndex();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UI.StartPage());
            //Favorite.addToFavorites(5, "World_energy_consumption");//Example of adding a favorite lemma to DB.
            
        }

       

    }
}
