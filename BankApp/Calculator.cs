using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Calculator
    {
        public void InterestType (Account account, ICalculator interestCalculate)
        {
            interestCalculate.Calculate(account);

        }
    }
}
