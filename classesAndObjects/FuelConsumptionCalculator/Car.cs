using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Car
    {
        private double _startKilometers; // Starting odometer reading
        private double _endKilometers; // Ending odometer reading
        private double _liters; // Liters of gas used between the readings

        public Car (double startOdo, double endingOdo, double liters)
        {
            this._startKilometers = startOdo;
            this._endKilometers = endingOdo;
            this._liters = liters;
        }

        public double CalculateConsumption() // Kilometers per litre
        {
            return (_endKilometers - _startKilometers) * _liters / 100;
        }

        public bool GasHog()
        {
            if (CalculateConsumption() >= 15)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EconomyCar()
        {
            if (CalculateConsumption() <= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
