using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog max = new Dog("Max", "male", "Lady", "Rocky");
            Dog rocky = new Dog("Rocky", "male", "Molly", "Buster");
            Dog sparky = new Dog("Sparky", "male", null, null);
            Dog buster = new Dog("Buster", "male", "Lady", "Sparky");
            Dog sam = new Dog("Sam", "male", null, null);
            Dog lady = new Dog("Lady", "female", null, null);
            Dog molly = new Dog("Molly", "female", null, null);
            Dog coco = new Dog("Coco", "female", "Molly", "Buster");

            Console.WriteLine(coco.fathersName());
            Console.WriteLine(sparky.fathersName());

            Console.WriteLine(coco.HasSameMotherAs(max));

            Console.ReadKey();
        }
    }
}
