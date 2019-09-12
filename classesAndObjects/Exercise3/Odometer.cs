using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Odometer
    {
        //FuelGauge fuelGauge = new FuelGauge();

        private int _milage;
        
        public void ReportMilage()
        {
            Console.WriteLine($"Current car milage is {_milage}");
        }

        public void AddMilage()
        {
            _milage++;
        }

        public void BurnFuel()
        {
            if(_milage % 10 == 0)
            {
                FuelGauge fuelGauge = new FuelGauge();
                fuelGauge.TakeFuel();
            }
        }
    }
}
