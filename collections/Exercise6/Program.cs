using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        private const string Path = "C:/Users/Andris/csharp-basics-homework/collections/Exercise6/lear.txt";

        static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);

            int lines = readText.Count();
            int words = 0;
            int chars = 0;

            foreach (var s in readText)
            {
                Console.WriteLine(s);
                char[] charCount = s.ToCharArray();
                int charsInLine = charCount.Length;
                chars += charsInLine;
            }

            Console.WriteLine();
            Console.WriteLine($"Lines = {lines}");

            StreamReader sr = new StreamReader(Path);
            string delim = " ,."; // What will be excluded
            string[] fields = null;
            string line = null;

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                line.Trim();
                fields = line.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                words += fields.Length; 
            }
            sr.Close();
            Console.WriteLine($"Words = {words}");

            Console.WriteLine($"Chars = {chars}");


            Console.ReadKey();
        }
    }
}
