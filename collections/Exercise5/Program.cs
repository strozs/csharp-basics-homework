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
            string input = Console.ReadLine();
            char[] charArr = input.ToCharArray();
            int sum = 0;
            

            foreach (char ch in charArr)
            {
                int result = int.Parse(ch.ToString());
                result *= result;
                Console.WriteLine(result);
                sum += result;
            }
            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
