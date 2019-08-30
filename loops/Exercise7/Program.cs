using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Piglet game

            Console.WriteLine("Welcome to Piglet!");

            Random random = new Random();
            int randomNr = random.Next(1, 6);
            Console.WriteLine($"You Rolled a {randomNr}");
            Console.Write("Roll again?(y/n)   ");

            int points = randomNr;

            string input = Console.ReadLine();

            /* if (input == "y")
            {
                int randomNr = random.Next(1, 6);
                points =+ randomNr;
            }
            else if (input == "n")
            {
                Console.WriteLine($"You got {points} points!");
            }  */

            while (input == "y")
            {
                randomNr = random.Next(1, 6);
                points += randomNr;

                if (randomNr == 1)
                {
                    Console.WriteLine("You rolled a 1, so you Lost!");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine($"You Rolled a {randomNr}");
                Console.Write("Roll again?(y/n)   ");
                input = Console.ReadLine();

            }

            if (input == "n")
            {
                Console.WriteLine($"You got {points} points!");
            }
            else
            {
                Console.Write("Wrong input");
            }

            Console.ReadKey();

        }
    }
}
