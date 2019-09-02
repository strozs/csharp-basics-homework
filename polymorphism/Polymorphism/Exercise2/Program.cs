using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<ISound>
            {
                new FireWork(),
                new Parrot(),
                new Radio(),
                new FireWork(),
                new Parrot(),
                new Radio()
            };

            list.ForEach(s => s.PlaySound());

            Console.ReadKey();
        }
    }
}
