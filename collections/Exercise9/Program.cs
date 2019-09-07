using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneDirectory jeff = new PhoneDirectory("Jeff", 23543454);
            PhoneDirectory bill = new PhoneDirectory("Bill", 12345678);
            PhoneDirectory jim = new PhoneDirectory("Jim", 87654321);

            jeff.PrintData(); //Prints data of object
            Console.WriteLine();

            PhoneDirectory.PrintAll(); //Prints data of all objects in Directory
            Console.WriteLine();

            PhoneDirectory.GetNumber("Jeff"); //Gets objetts value by its key / gets number by name
            PhoneDirectory.GetNumber("Bob");

            Console.ReadKey();
        }
    }
}
