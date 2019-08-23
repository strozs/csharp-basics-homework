using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            FuelGauge fuelGauge = new FuelGauge();
            Odometer odometer = new Odometer();

            for (int i = 0; i < 50; i++)
            {
                odometer.ReportMilage();
                fuelGauge.ReportFuel();
                
                for (int j = 0; j < 15; j++)
                {
                    odometer.AddMilage();
                }

                odometer.BurnFuel();

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
