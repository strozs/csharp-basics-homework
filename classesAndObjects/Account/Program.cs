using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            var bartosAccount = new Account("Barto's account", 100.00);
            var bartosSwissAccount = new Account("Barto's account in Switzerland", 1000000.00);

            Console.WriteLine("Initial state");
            Console.WriteLine(bartosAccount.balance());
            Console.WriteLine(bartosSwissAccount.balance());
            Console.WriteLine();


            bartosAccount.withdrawal(20);
            Console.WriteLine("Barto's account balance is now: " + bartosAccount.balance());
            bartosSwissAccount.deposit(200);
            Console.WriteLine("Barto's Swiss account balance is now: " + bartosSwissAccount.balance());
            Console.WriteLine();


            Console.WriteLine("Final state");
            Console.WriteLine(bartosAccount.balance());
            Console.WriteLine(bartosSwissAccount.balance());

            var aAccount = new Account("A Account", 100.00);
            var bAccount = new Account("B Account", 0);
            var cAccount = new Account("C Account", 0);

            Account.Transfer(aAccount, bAccount, 50.0);
            Account.Transfer(bAccount, cAccount, 25.0);


            Console.WriteLine();
            Console.WriteLine("Final state");
            Console.WriteLine(aAccount.balance());
            Console.WriteLine(bAccount.balance());
            Console.WriteLine(cAccount.balance());

            Console.ReadKey();
        }
    }
}
