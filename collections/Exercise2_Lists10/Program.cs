﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_Lists10
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };

            Console.WriteLine("Original array list: ");
            Console.WriteLine(string.Join(",", colors));

            //TODO: Remove all elements from list --DONE--
            colors.Clear();

            Console.WriteLine("New array list: ");
            Console.WriteLine(string.Join(",", colors));

            Console.ReadKey();
        }
    }
}
