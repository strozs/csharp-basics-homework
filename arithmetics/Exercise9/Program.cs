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
            double myBMI = BMI(180, 60);
            Console.WriteLine($"Your BMI is: {myBMI:0.00}");
            if (myBMI < 18.5)
            {
                Console.WriteLine("Your Underweight!");
            }
            else if (myBMI > 25)
            {
                Console.WriteLine("Your Overweight!");
            }
            else
            {
                Console.WriteLine("Your Optimal Weight!");
            }
            Console.ReadKey();
        }

        static double BMI(double height, double weight)
        {
            return 703 * (weight * 2.20462262) / ((height * 0.393700787) * (height * 0.393700787));
        }
    }
}
