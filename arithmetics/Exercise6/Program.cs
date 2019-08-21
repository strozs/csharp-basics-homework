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
            Console.WriteLine("Program CozaLozaWoza");
            for (int i = 1; i <= 110; i++)
            {
                Console.Write(i + " ");
                if (i % 11 == 0)
                {
                    Console.WriteLine();
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Coza");
                }
            }
            Console.ReadKey();
        }
    }
}
