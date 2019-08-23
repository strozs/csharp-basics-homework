using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_Lists1
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Write a C# program to create a new list, add some elements (string) and print out the collection.
            var colors = new List<string>();

            //TODO: Add 5 colors to list --DONE--
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Purple");
            colors.Add("Yellow");
            colors.Add("Black");

            Console.WriteLine(string.Join(", ", colors));

            Console.ReadKey();
        }
    }
}
