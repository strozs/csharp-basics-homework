using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string classOne = "Class One";
            string classTwo = "Class Two";
            string classThree = "Class Three";
            string classFour = "Class Four";
            string classFive = "Class Five";
            string classSix = "Class Six";
            string classSeven = "Class Seven";
            string classEight = "Class Eight";

            string teacherOne = "Teacher One";
            string teacherTwo = "Teacher Two";
            string teacherThree = "Teacher Three";
            string teacherFour = "Teacher Four";
            string teacherFive = "Teacher Five";
            string teacherSix = "Teacher Six";
            string teacherSeven = "Teacher Seven";
            string teacherEight = "Teacher Eight";

            Console.WriteLine("+------------------------------------------------------------+");
            Console.WriteLine($"| 1 |                          {classOne} |       {teacherOne} |");
            Console.WriteLine($"| 2 |                          {classTwo} |       {teacherTwo} |");
            Console.WriteLine($"| 3 |                        {classThree} |     {teacherThree} |");
            Console.WriteLine($"| 4 |                         {classFour} |      {teacherFour} |");
            Console.WriteLine($"| 5 |                         {classFive} |      {teacherFive} |");
            Console.WriteLine($"| 6 |                          {classSix} |       {teacherSix} |");
            Console.WriteLine($"| 7 |                        {classSeven} |     {teacherSeven} |");
            Console.WriteLine($"| 8 |                        {classEight} |     {teacherEight} |");
            Console.WriteLine("+------------------------------------------------------------+");


            Console.ReadKey();
        }
    }
}
