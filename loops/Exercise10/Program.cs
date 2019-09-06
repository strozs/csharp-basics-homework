using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter min: ");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter max: ");
            int max = Convert.ToInt32(Console.ReadLine());

            int i, j, k;
            for (i = min; i <= max; i++)
            {
                k = i;
                for (j = min; j <= max; j++)
                {
                    if (k <= max)
                    {
                        Console.Write(k);
                    }
                    else
                    {
                        Console.Write(k = min);
                    }
                    k++;
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
