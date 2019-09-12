using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Accounts
    {
        private string _name;
        private decimal _balance;

        public Accounts (string name, decimal balance)
        {
            this._name = name;
            this._balance = balance;
        }

        public void ShowUserNameAndBalance()
        {
            if (_balance > 0)
            {
                Console.WriteLine($"{_name}, ${_balance.ToString("#,##0.00")}");
            }
            else
            {
                _balance *= -1;
                Console.WriteLine($"{_name}, -${_balance.ToString("#,##0.00")}");
            }
            //Console.Write($"{_name}, ${_balance.ToString("#,##0.00")}");
        }
    }
}
