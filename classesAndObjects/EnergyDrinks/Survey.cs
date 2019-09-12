using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDrinks
{
    class Survey
    {
        private const int NumberedSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;

        public int GetNumbereSurveyed()
        {
            return NumberedSurveyed;
        }
        public double CalculateEnergyDrinkers()
        {
            return NumberedSurveyed * PurchasedEnergyDrinks;
        }

        public double CalculatePreferCitrus()
        {
            return CalculateEnergyDrinkers() * PreferCitrusDrinks;
        }
    }
}
