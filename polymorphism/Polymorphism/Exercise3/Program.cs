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
            /*
             * - Create an instant of class Student and an instant of class Employee with proper values for the attributes.
             * - Display the content of each class using Display() method.
             */

            Student student = new Student("Andris", "Strozs", "Riga Street", 69, 13);
            student.Display();

            Console.WriteLine();

            Employee emp = new Employee("Bob", "Burgers", "Burger Street", 45, "Cook");
            emp.Display();

            Console.ReadKey();
        }
    }
}
