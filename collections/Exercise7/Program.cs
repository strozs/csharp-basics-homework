using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        private const string Path = "C:/Users/Andris/csharp-basics-homework/collections/Exercise7/flights.txt";
        static void Main(string[] args)
        {
            List<string> flights = File.ReadAllLines(Path).ToList();
            /*foreach (var s in flights)
            {
                Console.WriteLine(s);
            }*/

            var listOfCities = new HashSet<string>();
            for (int i = 0; i < flights.Count; i++)
            {
                listOfCities.Add(flights[i].Substring(0, flights[i].IndexOf("->")));
            }

            string input = "";
            while (input != "0")
            {
                Console.WriteLine("What would you like to do:");
                Console.WriteLine("To display list of the cities press 1");
                Console.WriteLine("To exit program press 0");
                input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("List of cities: ");
                    foreach (var item in listOfCities)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine();

                    Console.WriteLine("To select a city from which you would like to start press 1");
                    Console.WriteLine("Press ENTER to go back");
                    string input2 = Console.ReadLine();
                    if (input2 == "1")
                    {
                        Console.WriteLine("Enter from witch citie you woul like to start");
                        string input3 = Console.ReadLine();

                    }
                }
            }

            




            Console.ReadKey();
        }
    }
}
