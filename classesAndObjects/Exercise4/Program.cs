using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie casino = new Movie("Casino Royale", "Eon Productions", "PG13");
            Movie glass = new Movie("Glass", "Buena Vista International", "PG13");
            Movie spider = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures");

            casino.PrintInfo();
            Console.WriteLine();
            glass.PrintInfo();
            Console.WriteLine();
            spider.PrintInfo();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
