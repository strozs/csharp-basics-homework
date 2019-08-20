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


            //fixme
            //Console.WriteLine("Original numeric array : " + myArray1);
            foreach (var item in myArray1)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            //Sort array
            //Console.WriteLine("Sorted numeric array : " + Array.Sort(myArray1));
            Array.Sort(myArray1);
            foreach (var item in myArray1)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            //Console.WriteLine("Original string array : " + );
            foreach (var item in myArray2)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            //Sort array
            //Console.WriteLine("Sorted string array : " + );
            Array.Sort(myArray2);
            foreach (var item in myArray2)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}
