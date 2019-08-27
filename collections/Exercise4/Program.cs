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
            Console.WriteLine("Enter listof names: ");

            var names = new HashSet<string>();

            string input = null;

            while (input != "")
            {
                input = Console.ReadLine();
                names.Add(input);
            }

            Console.Write("Unique name list contains: ");
            Console.Write(string.Join(" " , names));

            Console.ReadKey();
        }
    }
}
