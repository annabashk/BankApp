using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class SalaryCalculateInterest : ICalculator
    {
        public void Calculate(Account account)
        {
            account.Interest = account.Balance * 0.5;
        }
    }
}
