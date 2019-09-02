using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Lexus : ICar, IModifiedCar
    {
        private int currentSpeed = 0;

        public string Name()
        {
            return "Lexus";
        }

        public void SpeedUp()
        {
            currentSpeed += 8;
        }

        public void SlowDown()
        {
            currentSpeed += 8;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine()
        {
            currentSpeed += 30;
        }

        public void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}
