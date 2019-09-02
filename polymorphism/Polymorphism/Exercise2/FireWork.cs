using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class FireWork : ISound
    {
        public void PlaySound()
        {
            Console.WriteLine("whoosh-bang");
        }
    }
}
