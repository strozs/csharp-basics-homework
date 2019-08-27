using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_Lists11
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Create an List with string elements --DONE--
            var animals = new List<string>
            {
                "Sloth",
                "Dog",
                "Cat",
                "Lion",
                "Fish"
            };

            //TODO: Add 10 values to list --DONE--
            animals.Add("Bug");
            animals.Add("Turtle");
            animals.Add("Bat");
            animals.Add("Bear");
            animals.Add("Shark");
            animals.Add("Lizard");
            animals.Add("Bird");
            animals.Add("Eagel");
            animals.Add("Sneak");
            animals.Add("Horse");

            //TODO: Add new value at 5th position --DONE--
            animals.Insert(4, "Dinosour");

            //TODO: Change value at last position (Calculate last position programmatically) --DONE--
            animals[15] = "Replaced";


            //TODO: Sort your list in alphabetical order --DONE--
            animals.Sort();

            //TODO: Check if your list contains "Foobar" element --DONE--
            if (animals.Contains("Foobar"))
            {
                Console.WriteLine("Contains Foobar");
            }
            else
            {
                Console.WriteLine("Does not contain Foobar");
            }
            Console.WriteLine();

            //TODO: Print each element of list using loop --DONE--
            for (int i = 0; i < animals.Count; i++)
            {
                Console.Write(animals[i] + " ");
            }


            Console.ReadKey();
        }
    }
}
