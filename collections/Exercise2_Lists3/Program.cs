using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_Lists3
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Write a C# program to insert an element into the array list at the first position. --DONE--

            var colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Orange");
            colors.Add("White");
            colors.Add("Black");

            Console.WriteLine(string.Join(", ", colors));

            //TODO: Add new color at the first and third position of the list
            colors.Insert(0, "Pink");
            colors.Insert(2, "Ketchup");

            //Print the list
            Console.WriteLine(string.Join(", ", colors));

            Console.ReadKey();
        }
    }
}
