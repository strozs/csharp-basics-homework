using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            string input = Console.ReadLine(); // Gets user input
            char[] charArr = input.ToCharArray(); //Converts input to char array
            List<char> lst = charArr.OfType<char>().ToList(); // converts char array to a list of chars
            int sum = 0;

            do
            {
                sum = 0;
                foreach (char ch in lst) 
                {
                    int number = int.Parse(ch.ToString()); // Converts char to string and then to int
                    number *= number;
                    Console.WriteLine(number);
                    sum += number;
                }
                Console.WriteLine("Sum is " + sum);
                lst.Clear(); // Clears original list
                string lstToString = Convert.ToString(sum); // Converts sum to string
                char[] newCharArr = lstToString.ToCharArray(); // Converts string to char array
                List<char> newLst = newCharArr.OfType<char>().ToList(); // converts char array to a list of chars
                lst.AddRange(newLst); // Adds the new list values to old list
            } while (lst.Count != 1);

            Console.WriteLine();

            if (sum == 1)
            {
                Console.WriteLine($"{input} is a HAPPY NUMBER!");
            }
            else
            {
                Console.WriteLine($"{input} is NOT a HAPPY NUMBER!");
            }

            Console.ReadKey();
        }
    }
}
