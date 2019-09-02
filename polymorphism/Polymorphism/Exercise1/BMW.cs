using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class BMW : ICar
    {
        private int currentSpeed = 0;

        public string Name()
        {
            return "BMW";
        }

        public void SpeedUp()
        {
            currentSpeed += 12;
        }

        public void SlowDown()
        {
            currentSpeed += 12;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}
