using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Tesla : ICar
    {
        private int currentSpeed = 0;

        public string Name()
        {
            return "Tesla";
        }

        public void SpeedUp()
        {
            currentSpeed += 20;
        }

        public void SlowDown()
        {
            currentSpeed += 20;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("-- silence ---");
        }
    }
}
