using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Accounts benben = new Accounts("Benson", 17.2m);
            Accounts bobbob = new Accounts("Bob", -56.7m);

            benben.ShowUserNameAndBalance();
            bobbob.ShowUserNameAndBalance();

            Console.ReadKey();
        }
    }
}
