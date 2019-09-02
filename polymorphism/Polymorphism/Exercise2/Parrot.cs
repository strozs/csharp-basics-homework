using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Parrot : ISound
    {
        public void PlaySound()
        {
            Console.WriteLine("Does parrot sounds");
        }
    }
}
