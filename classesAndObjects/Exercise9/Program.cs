using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {

        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);
            SwapPoints(p1, p2);

            Console.WriteLine("(" + p1.X + ", " + p1.Y + ")");
            Console.WriteLine("(" + p2.X + ", " + p2.Y + ")");

            Console.ReadKey();
        }

        public static void SwapPoints(Point x, Point y)
        {
            int i = x.X;
            int j = x.Y;

            x.X = y.X;
            x.Y = y.Y;

            y.X = i;
            y.Y = j;
        }
    }
}
