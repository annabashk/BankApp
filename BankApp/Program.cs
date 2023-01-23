using System;

namespace BankApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var interest = new Calculator();
            var account = new Account();
            //account.Type = "Обычный";
            account.Balance = 10000;

            interest.InterestType(account, new NormalCalculateInterest());
            //Console.WriteLine();
        }
    }
}