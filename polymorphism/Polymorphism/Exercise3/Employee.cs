using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Employee : Person
    {
        
        private string _jobTitle;

        public Employee(string firstName, string lastName, string adress, int id, string jobTitle)
        {
            _firstName = firstName;
            _lastName = lastName;
            _adress = adress;
            _id = id;
            _jobTitle = jobTitle;
        }

        public override void Display()
        {
            Console.WriteLine($"First Name: {_firstName}");
            Console.WriteLine($"Last Name: {_lastName}");
            Console.WriteLine($"Adress: {_adress}");
            Console.WriteLine($"#ID: {_id}");
            Console.WriteLine($"Job Title: {_jobTitle}");
        }
    }
}
