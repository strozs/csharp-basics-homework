using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        //-----------------------------------------------------------------
        // Creates a staff of employees for a firm and pays them.
        //-----------------------------------------------------------------

        static void Main(string[] args)
        {
            var personnel = new Staff();
            personnel.Payday();


            Console.ReadKey();
        }
    }
}
