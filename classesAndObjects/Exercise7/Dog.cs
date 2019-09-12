using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Dog
    {
        private string _name;
        private string _sex;
        private string _mother;
        private string _father;

        public Dog (string name, string sex, string mother, string father)
        {
            this._name = name;
            this._sex = sex;
            this._mother = mother;
            this._father = father;
        }

        public string fathersName()
        {
            if (_father != null)
            {
                return _father;
            }
            return "Unknown";
        }

        public bool HasSameMotherAs(Dog otherDog)
        {
            if (otherDog._mother == _mother)
            {
                return true;
            }
            return false;
        }
    }
}
