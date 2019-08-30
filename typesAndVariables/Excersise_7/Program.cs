using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter A Word");
            string  word = Console.ReadLine();

            string outputStr = String.Concat(word.Where(x => Char.IsUpper(x)));
            Console.WriteLine($"Number of uppercase letters is: {outputStr.Length}");

            Console.ReadKey();
        }
    }
}
