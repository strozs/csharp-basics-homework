using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PhoneDirectory jeff = new PhoneDirectory();
            jeff.PutNumber("Jeff", "24354657");

            Console.ReadKey();
        }
    }
}
