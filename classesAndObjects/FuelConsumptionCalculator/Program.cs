using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            double startKilometers, endKilometers, liters;
            double startKilometers2, endKilometers2, liters2;


            Console.Write("Enter first reading: ");
            startKilometers = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter second reading: ");
            endKilometers = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter liters consumed: ");
            liters = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();


            Console.Write("Enter first reading: ");
            startKilometers2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter second reading: ");
            endKilometers2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter liters consumed: ");
            liters2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Car car = new Car( startKilometers, endKilometers, liters);
            Car car2 = new Car(startKilometers2, endKilometers2, liters2);

            Console.WriteLine("Liters per 100km for first car are " + car.CalculateConsumption());
            if (car.GasHog())
            {
                Console.WriteLine("This car is a GAS HOG!");
            }
            else if (car.EconomyCar())
            {
                Console.WriteLine("This car is an Economy Car!");
            }

            Console.WriteLine();

            Console.WriteLine("Liters per 100km for second car are " + car2.CalculateConsumption());
            if (car2.GasHog())
            {
                Console.WriteLine("This car is a GAS HOG!");
            }
            else if (car2.EconomyCar())
            {
                Console.WriteLine("This car is an Economy Car!");
            }

            Console.ReadLine();
        }
    }
}
