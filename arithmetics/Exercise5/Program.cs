using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
            int randomNr = RandomNumber(1, 100); //Random nr
            int number = int.Parse(Console.ReadLine()); //Your guess
            if (number > randomNr)
            {
                Console.WriteLine($"Sorry, you are too high.  I was thinking of {randomNr}.");
            }
            else if (number < randomNr)
            {
                Console.WriteLine($"Sorry, you are too low.  I was thinking of {randomNr}.");
            }
            else
            {
                Console.WriteLine("You guessed it!  What are the odds?!?");
            }
            Console.ReadKey();
        }

        static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
