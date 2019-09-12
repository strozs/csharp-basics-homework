using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    public class PhoneDirectory
    {
        public static SortedDictionary<string, int> _data = new SortedDictionary<string, int>();
        private string _name;
        private int _number;

        public PhoneDirectory(string name, int number)
        {
            this._name = name;
            this._number = number;
            _data.Add(name, number);
        }

        public void PrintData ()
        {
            Console.WriteLine($"Name: {_name}   Number: {_number}");
        }


        public static void PrintAll()
        {
            foreach (KeyValuePair<string, int> pair in _data)
            {
                Console.WriteLine($"{pair.Key}  {pair.Value}");
            }
        }

        public static void GetNumber(string name)
        {
            bool found = false;

            foreach (KeyValuePair<string, int> pair in _data)
            {
                if (pair.Key == name)
                {
                    Console.WriteLine($"{pair.Value}");
                    found = true;
                }
            }

            if (found == false)
            {
                Console.WriteLine($"Person was not found!");
            }
        }
    }
}
