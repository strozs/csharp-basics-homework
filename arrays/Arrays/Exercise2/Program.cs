using System;
using System.Linq;

namespace Exercise2
{
    class Program
    {
        //TODO: Write a C# program to sum values of an array.
        private static void Main(string[] args)
        {
            int[] myArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var sum = myArray.Sum();


            //fixme
            /*for (int i = 0; i <= myArray.Length; i++)
            {
                Console.WriteLine(sum);
                
            }*/



            Console.WriteLine("The sum is " + sum);

            Console.ReadKey();
        }
    }
}
