using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Epmployee 1 Pay: " + PayCalculator(7.50, 35));
            Console.WriteLine();
            Console.WriteLine("Epmployee 2 Pay: " + PayCalculator(8.20, 47));
            Console.WriteLine();
            Console.WriteLine("Epmployee 3 Pay: " + PayCalculator(10.00, 73));
            Console.ReadKey();
        }

        static double PayCalculator(double oneHourPay, double hours)
        {
            double basePay = 0.00;
            if (oneHourPay > 8.00)
            {
                if (hours <= 40)
                {
                    basePay = oneHourPay * hours;
                }
                else if (hours > 40 && hours < 60)
                {
                    double overTimeHours = hours - 40;
                    double regularPayHours = hours - overTimeHours;
                    basePay = (regularPayHours * oneHourPay) + (overTimeHours * (oneHourPay * 1.5));
                }
                else if (hours > 60)
                {
                    Console.WriteLine("Error: Too many hours in one week");
                }
                return basePay;
            }
            else
            {
                Console.WriteLine("Error: Pay too little");
                return basePay;
            }
        }
    }
}
