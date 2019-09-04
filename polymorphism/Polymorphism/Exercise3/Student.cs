using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Student : Person
    {
        
        private int _gpa;

        public Student(string firstName, string lastName, string adress, int id, int gpa)
        {
            _firstName = firstName;
            _lastName = lastName;
            _adress = adress;
            _id = id;
            _gpa = gpa;
        }

        public override void Display()
        {
            Console.WriteLine($"First Name: {_firstName}");
            Console.WriteLine($"Last Name: {_lastName}");
            Console.WriteLine($"Adress: {_adress}");
            Console.WriteLine($"#ID: {_id}");
            Console.WriteLine($"GPA: {_gpa}");
        }
    }
}
