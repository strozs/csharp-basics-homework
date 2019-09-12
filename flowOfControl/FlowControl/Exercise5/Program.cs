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
            // PhoneKeyPad prompts user for a String, and converts to a sequence of keypad digits.
            Console.WriteLine("Enter letters: ");
            string input = Console.ReadLine().ToLower();
            char[] charArr = input.ToCharArray();

            foreach (char c in charArr)
            {
                switch (c)
                {
                    case 'a':
                    case 'b':
                    case 'c':
                        Console.Write(2);
                        break;

                    case 'd':
                    case 'e':
                    case 'f':
                        Console.Write(3);
                        break;

                    case 'g':
                    case 'h':
                    case 'i':
                        Console.Write(4);
                        break;

                    case 'j':
                    case 'k':
                    case 'l':
                        Console.Write(5);
                        break;

                    case 'm':
                    case 'n':
                    case 'o':
                        Console.Write(6);
                        break;

                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                        Console.Write(7);
                        break;

                    case 't':
                    case 'u':
                    case 'v':
                        Console.Write(8);
                        break;

                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        Console.Write(9);
                        break;

                    default:
                        Console.WriteLine("Something went wrong!");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
