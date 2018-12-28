using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encyclopedia.Controller
{
    class Random
    {
        public static Lemma getRandomLemma()
        {
            //Get a random lemma title from the DB.
            String randomLemmaTitle = DBConnect.getRandomLemmaTitle();
            //Get the needed properties of the lemma.
            byte[] lemmaBody = DBConnect.GetLemmaBodyByTitle(randomLemmaTitle);
            int lemmaCategory = DBConnect.GetLemmaCategoryByTitle(randomLemmaTitle);
            //Create a Lemma object.
            Lemma lemma = new Lemma(randomLemmaTitle, lemmaBody, lemmaCategory);
            return lemma;
        }
    }
}
