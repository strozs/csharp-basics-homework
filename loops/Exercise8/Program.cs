using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of rows: ");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                for (int j = 1; j < 8 - i; j++)
                    Console.Write("/");
                for (int k = 2; k < (2 * i + 2); k++)
                    Console.Write("*");
                for (int j = 1; j < 8 - i; j++)
                    Console.Write("\\");
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
