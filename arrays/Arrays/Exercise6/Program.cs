using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();


            int[] myArray1 =
            {
                random.Next(0, 100), random.Next(0, 100), random.Next(0, 100), random.Next(0, 100), random.Next(0, 100),
                random.Next(0, 100), random.Next(0, 100), random.Next(0, 100), random.Next(0, 100), random.Next(0, 100),
            };


            //Copies first array to the second
            int[] myArray2 = new int[10];
            Array.Copy(myArray1, myArray2, myArray1.Length);


            //Change the last value of first array to -7
            myArray1[9] = -7;


            //Prints out both arrays
            foreach (var item in myArray1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            foreach (var item in myArray2)
            {
                Console.Write(item + " ");
            }


            Console.ReadKey();
        }
    }
}
