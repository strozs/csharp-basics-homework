using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_Lists4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list and add some colors to the list --DONE--
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            string element = colors[0];
            Console.WriteLine("First element: " + element);

            element = colors[2];
            Console.WriteLine("Third element: " + element);

            Console.ReadKey();
        }
    }
}
