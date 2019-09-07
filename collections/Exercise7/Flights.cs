using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Flights
    {
        public static string SJ = "San Jose";
        public static string NY = "New York";
        public static string A = "Anchorage ";
        public static string H = "Honolulu ";
        public static string D = "Denver";
        public static string SF = "San Francisco";
        public static string Route;

        public static void fromSJ()
        {
            Route += "San Jose --> ";
            Console.WriteLine($"From {SJ}, you can go to: {SF}, {A}");
            Console.WriteLine($"Enter Your Next Destination!");
            Console.WriteLine();
        }

        public static void fromNY()
        {
            Route += "New York --> ";
            Console.WriteLine($"From {NY}, you can go to: {A}, {SJ}, {SF}, {H}");
            Console.WriteLine($"Enter Your Next Destination!");
            Console.WriteLine();
        }

        public static void fromA()
        {
            Route += "Anchorage --> ";
            Console.WriteLine($"From {A}, you can go to: {NY}, {SJ}");
            Console.WriteLine($"Enter Your Next Destination!");
            Console.WriteLine();
        }

        public static void fromH()
        {
            Route += "Honolulu --> ";
            Console.WriteLine($"From {H}, you can go to: {NY}, {SF}");
            Console.WriteLine($"Enter Your Next Destination!");
            Console.WriteLine();
        }

        public static void fromD()
        {
            Route += "Denver --> ";
            Console.WriteLine($"From {D}, you can go to: {SJ}");
            Console.WriteLine($"Enter Your Next Destination!");
            Console.WriteLine();
        }

        public static void fromSF()
        {
            Route += "San Francisco --> ";
            Console.WriteLine($"From {SF}, you can go to: {NY}, {H}, {D}");
            Console.WriteLine($"Enter Your Next Destination!");
            Console.WriteLine();
        }
    }
}
