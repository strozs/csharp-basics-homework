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
            Console.Write("Enter desired Sum (2-12): ");
            int input = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            //int randomNr = random.Next(1, 6);

            int sumOfRandom = 0;

            
             if (input > 1 && input < 13)
             {
                for (int i = 0; i < 100; i++)
                {
                    int randomNr1 = random.Next(1, 7);
                    int randomNr2 = random.Next(1, 7);
                    sumOfRandom = randomNr1 + randomNr2;
                    Console.WriteLine($"{randomNr1} and {randomNr2} = {sumOfRandom}");

                    if (input == sumOfRandom)
                    {
                        break;
                    }
                }
             }
             else
             {
                Console.WriteLine("Entered invalid value!");
             }
            

            Console.ReadKey();
        }
    }
}
