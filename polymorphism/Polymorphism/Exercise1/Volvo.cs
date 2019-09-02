using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Volvo : ICar, IModifiedCar
    {
        private int currentSpeed = 0;

        public string Name()
        {
            return "Volvo";
        }

        public void SpeedUp()
        {
            currentSpeed += 10;
        }

        public void SlowDown()
        {
            currentSpeed += 10;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }

        public void UseNitrousOxideEngine()
        {
            currentSpeed += 40;
        }
    }
}
