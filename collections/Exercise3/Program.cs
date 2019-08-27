using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySet = new HashSet<string>();

            //TODO: add 5 values to Set. --DONE--
            mySet.Add("Red");
            mySet.Add("Black");
            mySet.Add("Yellow");
            mySet.Add("White");
            mySet.Add("Green");


            Console.WriteLine("Should have 5 elements: ");
            Console.WriteLine(string.Join(",", mySet)); //Pay attention on order!
            Console.WriteLine();
            //TODO: iterate through all elements in set --DONE--
            
            foreach (string i in mySet)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //TODO: remove all values from set --DONE--
            mySet.Clear();
            Console.WriteLine("Is mySet empty: ");
            Console.WriteLine(mySet.Count == 0);

            //TODO: check if it is possible to add duplicated values --DONE--
            mySet.Add("Green");
            mySet.Add("Orange");
            mySet.Add("Green");
            mySet.Add("Purple");

            Console.WriteLine(string.Join(",", mySet));

            Console.ReadKey();
        }
    }
}
