using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var carsList = new List<ICar>
            {
                new Audi(), new BMW(), new Lexus(), new Tesla(), new Volvo(),
                new Audi(), new BMW(), new Lexus(), new Tesla(), new Volvo()
            };

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < carsList.Count; j++)
                {
                    if (j == 2) // Pārbauda vai ir nitro
                    {
                        if (carsList[j] is IModifiedCar)
                        {
                            ((IModifiedCar)carsList[j]).UseNitrousOxideEngine();
                        }

                    }
                    else
                    {
                        carsList[j].SpeedUp();
                    }
                }
            }


            carsList = carsList.OrderByDescending(c => c.ShowCurrentSpeed()).ToList();

            Console.WriteLine($"{carsList.First().Name()} {carsList.First().ShowCurrentSpeed()}");

            Console.WriteLine();
            Console.WriteLine("Other Cars");
            carsList.ForEach(c => Console.WriteLine($"{c.Name()} {c.ShowCurrentSpeed()}"));

            Console.ReadKey();
        }
    }
}
