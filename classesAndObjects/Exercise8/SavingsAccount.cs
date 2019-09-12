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
        public decimal TotalDeposite;
        public decimal TotalWithdrawn;

        public SavingsAccount (decimal startingBalance)
        {
            this._balance = startingBalance;
        }

        public void Withdrawal (decimal subtracting)
        {
            _balance -= subtracting;
            TotalWithdrawn -= subtracting;
        }

        public void Depposit(decimal depposit)
        {
            _balance += depposit;
            TotalDeposite += depposit;
        }

        public decimal MonthlyInterest (decimal annualIntrest)
        {
            return annualIntrest / 12;
        }

        public void PrintBlance ()
        {
            Console.WriteLine($"Your balance is ${_balance}");
        }

        public decimal ReturnBalance ()
        {
            return _balance;
        }


    }
}
