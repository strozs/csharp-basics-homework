using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account
    {
        private string _name;
        private double _money;

        public Account(string v1, double v2)
        {
            _name = v1;
            _money = v2;
        }

        public double withdrawal(double i)
        {
            _money -= i;
            return _money;
        }

        public double deposit(double i)
        {
            _money += i;
            return _money;
        }

        public double balance()
        {
            return _money;
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            from.withdrawal(howMuch);
            to.deposit(howMuch);
        }
    }
}
