using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excersise 1 checks for 15, sum of 15 or difference
            Console.WriteLine(CheckNumbers(a: Convert.ToInt32(Console.ReadLine()), b: Convert.ToInt32(Console.ReadLine())));

            Console.ReadKey();
        }

        static bool CheckNumbers(int a, int b)
        {
            return a == 15 || b == 15 || a + b == 15 || a - b == 15;
        }
    }
}
