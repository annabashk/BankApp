using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class NormalCalculateInterest : ICalculator
    {
        public void Calculate(Account account)
        {
            account.Interest = account.Balance * 0.4;
            if (account.Balance < 1000.0)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance < 50000.0)
                account.Interest -= account.Balance * 0.4;

            //Console.WriteLine(account.Interest);
        }
    }
}
