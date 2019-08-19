using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersis_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number of minutes!");

            int minutes = Convert.ToInt32(Console.ReadLine());

            int minutesToYears = minutes / 60 / 24 / 365;
            int minutesToDays = minutes / 60 / 24;

            Console.WriteLine($"{minutes} is {minutesToYears} years");
            Console.WriteLine($"{minutes} is {minutesToDays} days");

            Console.ReadKey();
        }
    }
}
