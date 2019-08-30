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
            int wrongAnswer = 0;

            string[] words = { "two", "orange" };
            string randomWord = words[new Random().Next(0, words.Length)];//Selects a random word from words array

            char[] charArr = randomWord.ToCharArray();//Converts randomWord to a char array

            char[] charArrBlank = new char[charArr.Length];//Converts charArr to a blank Array
            for (int i = 0; i < charArr.Length; i++)
            {
                charArrBlank[i] = '_';
            }

            Console.Write("Word: ");
            foreach (char c in charArrBlank)
            {
                Console.Write(c);
            }

            Console.WriteLine();

            for (int i = 0; i < charArr.Length + 2; i++)
            {
                Console.Write("Guess: ");
                char input = Convert.ToChar(Console.ReadLine());

                int index1 = randomWord.IndexOf(input, 0); //Shows the index of input char, shows -1 if not found

                if (index1 >= 0)
                {
                    charArrBlank[index1] = input;

                    Console.WriteLine();
                    Console.Write("Word: ");
                    Console.WriteLine(charArrBlank);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Wrong letter");
                    Console.Write("Word: ");
                    Console.WriteLine(charArrBlank);
                    Console.WriteLine();
                    wrongAnswer++;
                }
            }

            if (wrongAnswer > 1)
            {
                Console.WriteLine();
                Console.WriteLine($"You Lost! You had {wrongAnswer} wrong answers!");
            }
            
            Console.ReadKey();
        }
    }
}
