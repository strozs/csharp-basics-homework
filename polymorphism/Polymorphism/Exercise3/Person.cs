using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Person
    {
        public string _firstName;
        public string _lastName;
        public string _adress;
        public int _id;



        public virtual void Display()
        {
            Console.WriteLine($"First Name: {_firstName}");
            Console.WriteLine($"Last Name: {_lastName}");
            Console.WriteLine($"Adress: {_adress}");
            Console.WriteLine($"#ID: {_id}");
        }
    }
}
