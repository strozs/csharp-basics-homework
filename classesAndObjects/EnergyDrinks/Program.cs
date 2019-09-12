using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDrinks
{
    class Program
    {
        private static void Main(string[] args)
        {
            Survey survey = new Survey();

            double energyDrinkers = Math.Round(survey.CalculateEnergyDrinkers());
            double preferCitrus = Math.Round(survey.CalculatePreferCitrus());

             Console.WriteLine("Total number of people surveyed " + survey.GetNumbereSurveyed());
             Console.WriteLine("Approximately " + energyDrinkers + " bought at least one energy drink");
             Console.WriteLine(preferCitrus + " of those " + "prefer citrus flavored energy drinks.");
             

            Console.ReadKey();
        }
    }
}
