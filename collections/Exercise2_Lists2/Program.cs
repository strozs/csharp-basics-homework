using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_Lists2
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Write a C# program to iterate through all elements in a list. --DONE--

            var colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Orange");
            colors.Add("White");
            colors.Add("Black");

            
            for (int i = 0; i < colors.Count; i++)
            {
              Console.WriteLine(colors[i]);
            }

            Console.ReadKey();
        }
    }
}
