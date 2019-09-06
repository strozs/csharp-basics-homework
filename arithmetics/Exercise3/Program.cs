using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            const int lowerBound = 1;
            const int upperBound = 100;
            for (var number = lowerBound; number <= upperBound; ++number)
            {
                sum += number;
            }
            double average = sum / upperBound;
            Console.WriteLine($"The sum of {lowerBound} to {upperBound} is {sum}");
            Console.WriteLine($"Avarage is {average:0.00}");
            Console.ReadKey();
        }
    }
}
