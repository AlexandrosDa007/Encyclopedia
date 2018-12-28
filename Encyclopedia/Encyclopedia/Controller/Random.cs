using System;
using Encyclopedia.Model;

namespace Encyclopedia.Controller
{
    class Random
    {
        public static Lemma getRandomLemma()
        {
            // Get a random lemma title from the DB.
            Lemma lemma = DBConnect.GetRandomLemma();
			/*
            // Get the needed properties of the lemma.
            byte[] lemmaBody = DBConnect.GetLemmaBodyByTitle(randomLemmaTitle);
            int lemmaCategory = DBConnect.GetLemmaCategoryByTitle(randomLemmaTitle);

            // Create a Lemma object.
            Lemma lemma = new Lemma(randomLemmaTitle, lemmaBody, lemmaCategory);
			*/
            return lemma;
        }
    }
}
