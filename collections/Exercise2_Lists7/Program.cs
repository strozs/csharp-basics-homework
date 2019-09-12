using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_Lists7
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            // TODO: Check if list contains "White" element --DONE--
                    if (colors.Contains("White")) 
                    {
                        Console.WriteLine("Found the element");
                    } 
                    else
                    {
                        Console.WriteLine("There is no such element");
                    }

            Console.ReadKey();
        }
    }
}
