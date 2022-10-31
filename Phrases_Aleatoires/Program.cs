// See https://aka.ms/new-console-template for more information
using System;

namespace Phrases_Aleatoires // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static string ObtenirUnElementAleatoire(string[] t)
        {
            Random r = new Random();
            int i = r.Next(t.Length);
            return t[i];
        }
        static void Main(string[] args)
        {
            var sujets = new string[]
            {
               "La chaussette",
               "La planète terre",
               "Un ourson",
               "Une algue"
            };

            var verbes = new string[]
            {
                "regarde",
                "grignotte",
                "marche",
                "s'accroche à"
            };

            var complements = new string[]
            {
                "une chouette",
                "la mer",
                "par terre",
                "dans le bain",
                "le soleil"
            };

            const int NB_PHRASES = 10;
            var phrasesUniques = new List<string>();
            int doublonsEvites = 0;

            while(phrasesUniques.Count < NB_PHRASES)
            {
                var sujet = ObtenirUnElementAleatoire(sujets);
                var verbe = ObtenirUnElementAleatoire(verbes);
                var complement = ObtenirUnElementAleatoire(complements);
                var phrase = sujet + " " + verbe + " " + complement;
                phrase = phrase.Replace("à la", "au");

                if (!phrasesUniques.Contains(phrase))
                {
                    phrasesUniques.Add(phrase);
                }
                else
                {
                    doublonsEvites++;
                }
            }

            foreach(var p in phrasesUniques)
            {
                Console.WriteLine(p);
            }
            // Console.WriteLine(phrase);
            Console.WriteLine();
            Console.WriteLine($"nombre de phrases uniques:{phrasesUniques.Count} ");
            Console.WriteLine($"nombre de phrases en doublons évitées:{doublonsEvites} ");
        }
    }
}
