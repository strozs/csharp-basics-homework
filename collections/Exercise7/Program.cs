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
            var readText = File.ReadAllLines(Path);
            foreach (var s in readText)
            {
                Console.WriteLine(s);
            }

            var flights = new Dictionary<string, string>();
            flights.Add("San Jose", "San Francisco");
            flights.Add("San Jose", "Anchorage"); //Shows error, becouse you cant add to of the same kays to a dictionary
            flights.Add("New York", "Anchorage");
            flights.Add("New York", "San Jose");
            flights.Add("New York", "San Francisco");
            flights.Add("New York", "Honolulu");
            flights.Add("Anchorage", "New York");
            flights.Add("Anchorage", "San Jose");
            flights.Add("Honolulu", "New York");
            flights.Add("Honolulu", "San Francisco");
            flights.Add("Denver", "San Jose");
            flights.Add("San Francisco", "New York");
            flights.Add("San Francisco", "Honolulu");
            flights.Add("San Francisco", "Denver");

            string allFlights = string.Join(";", flights.Select(x => x.Key + "=" + x.Value).ToArray());
            Console.WriteLine(allFlights);


            Console.WriteLine("What would you like to do:");
            Console.WriteLine("To display list of the cities press 1");
            Console.WriteLine("To exit program press 0");


            Console.ReadKey();
        }
    }
}
