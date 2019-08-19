using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double distanceInMeters = 2500;
            double timeHours = 5;
            double timeMinutes = 56;
            double timeSeconds = 23;
            double totalTimeInSeconds = timeSeconds + (timeMinutes * 60) + ((timeHours * 60) * 60);

            double speedMS = distanceInMeters / totalTimeInSeconds;
            double speedKMH = (distanceInMeters / 1000) / (totalTimeInSeconds / 60 / 60);
            double speedMilesH = (2500 * 0.0006213) / (totalTimeInSeconds / 60 / 60);

            Console.WriteLine($"Your speed in meters/second is {speedMS}");
            Console.WriteLine($"Your speed in km/h is {speedKMH}");
            Console.WriteLine($"Your speed in miles/h is {speedMilesH}");

            Console.ReadKey();
        }
    }
}
