using System;
using Encyclopedia.Model;

namespace Encyclopedia.Controller
{
	/// <summary>
	/// Contains a function that sets up the 'Featured Lemma', getting a random lemma from the DB.
	/// </summary>
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
