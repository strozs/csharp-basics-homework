using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class FuelGauge
    {
        //Odometer odometer = new Odometer();

        private int _amountOfFuel = 10;
        private int _maxFuel = 70;

        public void ReportFuel()
        {
            Console.WriteLine($"Curren fuel level is {_amountOfFuel}");
        }

        public void AddFuel(int fuel)
        {
            if(_amountOfFuel < _maxFuel)
            {
                _amountOfFuel += fuel;
            }
        }

        public void TakeFuel()
        {
            if (_amountOfFuel > 0)
            {
                _amountOfFuel--;
            }
        }
    }
}
