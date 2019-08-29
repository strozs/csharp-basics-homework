using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class SavingsAccount
    {
        private decimal _balance;
        private decimal _intrestRate;

        public SavingsAccount (decimal startingBalance)
        {
            this._balance = startingBalance;
        }

        public void Withdrawal (decimal subtracting)
        {
            _balance -= subtracting;
        }

        public void Depposit(decimal depposit)
        {
            _balance += depposit;
        }

        public void MonthlyInterest ()
        {
            decimal intrestAmount = _balance * _intrestRate;
            _balance += intrestAmount;
        }

        public void PrintBlance ()
        {
            Console.WriteLine($"Your balance is {_balance}");
        }
    }
}
