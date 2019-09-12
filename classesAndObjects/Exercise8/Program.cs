using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much money is in the account?: ");
            decimal balance = decimal.Parse(Console.ReadLine());

            Console.Write("Enter the annual interest rate: ");
            decimal interest = decimal.Parse(Console.ReadLine());

            Console.Write("How long has the account been opened?: ");
            decimal howLongOpen = decimal.Parse(Console.ReadLine());

            SavingsAccount savingsAccount = new SavingsAccount(balance);
            decimal montlyIntrest = savingsAccount.MonthlyInterest(interest);
            decimal sumMonthlyIntrest;

            Console.WriteLine();

            for (int i = 1; i <= howLongOpen; i++)
            {
                Console.Write($"Enter amount deposited for month {i} ");
                decimal monthlyDeposit = decimal.Parse(Console.ReadLine());
                savingsAccount.Depposit(monthlyDeposit);

                Console.Write($"Enter amount withdrawn for mont {i}: ");
                decimal monthlyWithdrawel = decimal.Parse(Console.ReadLine());
                savingsAccount.Withdrawal(monthlyWithdrawel);


                Console.WriteLine();
            }
            savingsAccount.PrintBlance();
            sumMonthlyIntrest = savingsAccount.ReturnBalance() * montlyIntrest;

            Console.WriteLine($"Interest earned: ${sumMonthlyIntrest.ToString("#.##")}");
            Console.WriteLine($"Total deposited: ${savingsAccount.TotalDeposite}");
            Console.WriteLine($"Total withdrawn: ${savingsAccount.TotalWithdrawn}");
            Console.WriteLine($"Ending balance: ${(savingsAccount.ReturnBalance() + sumMonthlyIntrest).ToString("#.##")}");

            Console.ReadKey();
        }
    }
}
