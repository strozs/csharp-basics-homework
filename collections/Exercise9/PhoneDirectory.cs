using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    public class PhoneDirectory
    {
        public SortedDictionary<string, string> _data;
        private int _dataCount;
        private string _name;
        private string _number;

        public PhoneDirectory(string name, string number)
        {
            _name = name;
            _number = number;
            _data.Add(name, number);
        }

        /*private int Find(string name)
        {
            for (var i = 0; i < _dataCount; i++)
            {
                if (_data[i].name.Equals(name))
                {
                    return i;
                }
            }
            return -1;
        } */

        public string GetNumber(string name)
        {
            string value = "";
            if (_data.TryGetValue(name, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /* public void PutNumber(string name, string number)
        {
            if (name == null || number == null)
            {
                throw new Exception("name and number cannot be null");
            }

            _data.Add(name, number);
            _dataCount++;
        } */
    }
}
