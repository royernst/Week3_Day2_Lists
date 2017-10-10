using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day2_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> testScores = new List<int>() { 98, 100, 76, 84, 93 };
            //testScores.Add(80);
            //testScores.Add(99);

            //List<int> luckyNumbers = new List<int>();
            //luckyNumbers.Add(2);
            //luckyNumbers.Add(3);
            //luckyNumbers.Add(5);
            //luckyNumbers.Add(7);
            //luckyNumbers.Add(1);
            ////Console.WriteLine(luckyNumbers.Count);

            //List<string> faveFoods = new List<string>() { "steak", "chicken", "fish", "ice cream", "nachos" };

            ////Check your list by printing each element individually
            ////Console.WriteLine(faveFoods[0]);
            ////Console.WriteLine(faveFoods[1]);
            ////Console.WriteLine(faveFoods[4]);

            //List<string> leastFaveFoods = new List<string>();
            //leastFaveFoods.Add("Brussel Sprouts");
            //leastFaveFoods.Add("Beets");
            //leastFaveFoods.Add("Shrimp");
            ////Console.WriteLine(leastFaveFoods[0]);

            //leastFaveFoods[0] = "Pizza";
            ////Console.WriteLine(leastFaveFoods[0]);

            //List<string> faveFilms = new List<string>() { "LOTR", "The Meteor Man", "Iron Sky", "The Iron Giant" };
            //for (int i = 0; i < faveFilms.Count; i++)
            //{
            //    Console.WriteLine(faveFilms[i]);
            //}

            //faveFilms.Insert(0, "Atlantis");
            //faveFilms.Insert(1, "Godzilla");
            //faveFilms.Insert(2, "Pan's Labyrinth");
            //Console.WriteLine();

            //foreach (string movie in faveFilms)
            //{
            //    Console.WriteLine(movie);
            //}

            //faveFilms.Remove("The Meteor Man");
            //faveFilms.Remove("Iron Sky");
            //Console.WriteLine();

            //foreach (string film in faveFilms)
            //{
            //    Console.WriteLine(film);
            //}

            List<string> animals = new List<string>();
            animals.Add("Doge");
            animals.Add("Cat");
            animals.Add("Armadillo");
            animals.Add("Echidna");
            animals.Add("Cassowary");

            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine();

            List<bool> boolList = new List<bool>() { true, false, false, true, false };
            foreach (bool boolean in boolList)
            {
                if (boolean == true)
                {
                    Console.WriteLine("Better bring an umbrella.");
                }
                else if (boolean == false)
                {
                    Console.WriteLine("No rain today, enjoy the sun!");
                }
                else
                {
                    //left blank
                }
            }

            Console.WriteLine();

            List<int> intList = new List<int>() { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };

            Console.WriteLine(intList.Contains(23));
            Console.WriteLine(intList.Contains(77));
            Console.WriteLine(intList.Contains(15));

            intList.Remove(27);
            intList.Remove(77);
            intList.Remove(32);
            intList.Remove(6);

            Console.WriteLine(intList.Contains(23));
            Console.WriteLine(intList.Contains(77));
            Console.WriteLine(intList.Contains(15));
        }
    }
}
