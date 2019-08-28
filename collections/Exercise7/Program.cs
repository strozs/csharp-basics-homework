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
        private const string Path = "D:/Codelex/csharp-basics-homework/collections/Exercise7/flights.txt";
        static void Main(string[] args)
        {
            List<string> flights = File.ReadAllLines(Path).ToList();
            foreach (var s in flights)
            {
                Console.WriteLine(s);
            }

            var listOfCities = new HashSet<string>();
            for (int i = 0; i < flights.Count; i++)
            {
                listOfCities.Add(flights[i].Substring(0, flights[i].IndexOf("->")));
            }

            Console.WriteLine("List of cities: ");
            foreach (var item in listOfCities)
            {
                Console.WriteLine(item);
            }

            


           /* Console.WriteLine("What would you like to do:");
            Console.WriteLine("To display list of the cities press 1");
            Console.WriteLine("To exit program press 0");*/


            Console.ReadKey();
        }
    }
}
