using System;

namespace Exercise1
{
    class Program
    {
        //TODO: Write a C# program to sort a numeric array and a string array.
        private static void Main(string[] args)
        {
            int[] myArray1 = {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2165, 1457, 2456
            };

            string[] myArray2 = {
                "Java",
                "Python",
                "PHP",
                "C#",
                "C Programming",
                "C++"
            };


            
            
            foreach (var item in myArray1)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            //Sort array
            
            Array.Sort(myArray1);
            foreach (var item in myArray1)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            
            foreach (var item in myArray2)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            //Sort array
            
            Array.Sort(myArray2);
            foreach (var item in myArray2)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}
