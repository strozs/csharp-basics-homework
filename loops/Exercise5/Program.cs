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
            Console.WriteLine("Enter first word: ");
            string word1 = Console.ReadLine();

            Console.WriteLine("Enter second word: ");
            string word2 = Console.ReadLine();

            int wordLenghts = word1.Length + word2.Length;

            Console.Write(word1);
            for (int i = 0; i < 30 - wordLenghts; i++)
            {
                Console.Write(".");
            }
            Console.Write(word2);

            Console.ReadKey();
        }
    }
}
