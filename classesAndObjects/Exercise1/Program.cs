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
            var mouse = new Product("Mouse", 79.99, 12);
            var phone = new Product("iPhone 5s", 499.99, 7);
            var speakers = new Product("Epson EB-U05", 299.99, 23);

            mouse.PrintProduct();
            phone.PrintProduct();
            speakers.PrintProduct();

            mouse.AddAmount(8); // Ads to mouse amount
            mouse.LowerAmount(2);

            mouse.AddPrice(5);
            mouse.LowerPrice(1);

            mouse.PrintProduct();

            Console.ReadKey();
        }
    }
}
