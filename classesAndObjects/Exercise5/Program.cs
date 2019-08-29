using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now.ToString("M/d/yyyy");
            Console.WriteLine(date);

            Console.ReadKey();
        }
    }
}
