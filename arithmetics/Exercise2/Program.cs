using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program: CheckOddEven   Enter a number!");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CheckOddEven(number));
            Console.WriteLine("Bye");
            Console.ReadKey();
        }

        static string CheckOddEven(int number)
        {
            if (number % 2 == 0)
            {
                return "Even Number";
            }
            else
            {
                return "Odd number";
            }
        }
    }
}
