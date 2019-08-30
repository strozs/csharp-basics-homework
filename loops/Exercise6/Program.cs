using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                if (i % 20 == 0 + 1)
                {
                    Console.WriteLine();
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else
                {
                    Console.Write(i + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
