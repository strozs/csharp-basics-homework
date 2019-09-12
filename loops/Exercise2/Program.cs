using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            int n;
            
            

            Console.WriteLine("Input number of times to multiply: ");
            n = Convert.ToInt32(Console.ReadLine());



            //todo - complete loop to multiply i with itself n times, it is NOT allowed to use Math.Pow()
            for (var j = 0; j < n; j++ )
            {
               
                Console.WriteLine(i * i);
                i = i * i;

            }

            Console.ReadKey();
        }
    }
}
