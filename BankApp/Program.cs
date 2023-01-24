using System;

namespace BankApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var interest = new Calculator();
            var account = new Account();
            account.Balance = 40000.0;

            Console.WriteLine("Если тип - обычный:");
            interest.InterestType(account, new NormalCalculateInterest());
            Console.WriteLine(account.Interest);

            Console.WriteLine("Если тип - зарплатный:");
            interest.InterestType(account, new SalaryCalculateInterest());
            Console.WriteLine(account.Interest);
        }
    }
}