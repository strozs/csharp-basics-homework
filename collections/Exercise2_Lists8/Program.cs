﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_Lists8
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Write a C# program to sort a given list. --DONE--

            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            Console.Write("List before sort: ");
            Console.WriteLine(string.Join(",", colors));

            //TODO: Sort list --DONE--
            colors.Sort();

            Console.Write("List after sort: ");
            Console.WriteLine(string.Join(",", colors));

            Console.ReadKey();
        }
    }
}
