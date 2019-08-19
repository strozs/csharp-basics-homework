using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 4 Single Digit Numbers");

            
            int nrOne = Convert.ToInt32(Console.ReadLine());
            int nrTwo = Convert.ToInt32(Console.ReadLine());
            int nrThree = Convert.ToInt32(Console.ReadLine());
            int nrFour = Convert.ToInt32(Console.ReadLine());

            int sum = nrOne + nrTwo + nrThree + nrFour;
            Console.WriteLine($"The sum of numbers is {sum}");


            Console.ReadKey();

        }
    }
}
