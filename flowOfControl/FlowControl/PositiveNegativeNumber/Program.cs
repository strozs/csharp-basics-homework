﻿using System;

namespace PositiveNegativeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Return what kind of number is it, positive or negative
            Console.WriteLine("Enter the number.");
            var input = Convert.ToInt32(Console.ReadLine());


            if (input > 0){
                Console.WriteLine("Number is positive");
            } else if (input < 0) {
                Console.WriteLine("Number is negative");
            } else {
                Console.WriteLine("Number is zero");
            }

            Console.ReadKey();

        }
    }
}
