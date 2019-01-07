using System;
using Encyclopedia.Model;

namespace Encyclopedia.Controller
{
    class Random
    {
        public static Lemma getRandomLemma()
        {
            // Get a random lemma from the DB.
            Lemma lemma = DBConnect.GetRandomLemma();

            return lemma;
        }
    }
}
