using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        private const string Path = "/../Codelex/csharp-basics-homework/collections/Exercise8/midtermscores.txt";
        static void Main(string[] args)
        {
            List<string> lines = File.ReadAllLines(Path).ToList();          

            List<string> numbers = new List<string>();

            foreach (string line in lines)
            {
                string[] entries = line.Split(' ');
                List<string> lst = entries.OfType<string>().ToList();
                numbers.AddRange(lst);
            }


            /*foreach (string line in numbers)
            {
                Console.WriteLine(line);
            }*/

            string one = "";
            string two = "";
            string three = "";
            string four = "";
            string five = "";
            string six = "";
            string seven = "";
            string eight = "";
            string nine = "";
            string ten = "";
            string eleven = "";

            foreach (string line in numbers)
            {
                int score = int.Parse(line);

                switch (score)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        one += "*";
                        break;

                    case 10:
                    case 11:
                    case 12:
                    case 13:
                    case 14:
                    case 15:
                    case 16:
                    case 17:
                    case 18:
                    case 19:
                        two += "*";
                        break;

                    case 20:
                    case 21:
                    case 22:
                    case 23:
                    case 24:
                    case 25:
                    case 26:
                    case 27:
                    case 28:
                    case 29:
                        three += "*";
                        break;

                    case 30:
                    case 31:
                    case 32:
                    case 33:
                    case 34:
                    case 35:
                    case 36:
                    case 37:
                    case 38:
                    case 39:
                        four += "*";
                        break;

                    case 40:
                    case 41:
                    case 42:
                    case 43:
                    case 44:
                    case 45:
                    case 46:
                    case 47:
                    case 48:
                    case 49:
                        five += "*";
                        break;

                    case 50:
                    case 51:
                    case 52:
                    case 53:
                    case 54:
                    case 55:
                    case 56:
                    case 57:
                    case 58:
                    case 59:
                        six += "*";
                        break;

                    case 60:
                    case 61:
                    case 62:
                    case 63:
                    case 64:
                    case 65:
                    case 66:
                    case 67:
                    case 68:
                    case 69:
                        seven += "*";
                        break;

                    case 70:
                    case 71:
                    case 72:
                    case 73:
                    case 74:
                    case 75:
                    case 76:
                    case 77:
                    case 78:
                    case 79:
                        eight += "*";
                        break;

                    case 80:
                    case 81:
                    case 82:
                    case 83:
                    case 84:
                    case 85:
                    case 86:
                    case 87:
                    case 88:
                    case 89:
                        nine += "*";
                        break;

                    case 90:
                    case 91:
                    case 92:
                    case 93:
                    case 94:
                    case 95:
                    case 96:
                    case 97:
                    case 98:
                    case 99:
                        ten += "*";
                        break;

                    case 100:
                        eleven += "*";
                        break;
                }
            }

            /*string eightStar = "";
            for (int i = 0; i <= eight; i++)
            {
                eightStar += "*";
            }*/

            Console.WriteLine("00-09: " + one);
            Console.WriteLine("10-19: " + two);
            Console.WriteLine("20-29: " + three);
            Console.WriteLine("30-39: " + four);
            Console.WriteLine("40-49: " + five);
            Console.WriteLine("50-59: " + six);
            Console.WriteLine("60-69: " + seven);
            Console.WriteLine("70-79: " + eight);
            Console.WriteLine("80-89: " + nine);
            Console.WriteLine("90-99: " + ten);
            Console.WriteLine("  100: " + eleven);


            Console.ReadKey();
        }
    }
}
