using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public interface ICalculator
    {
        void Calculate(Account account);
    }
}
