using System;

namespace StateSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account("段誉", 0.0);
            acc.Deposit(1000);
            acc.Withdraw(2000);
            acc.Deposit(3000);
            acc.Withdraw(4000);
            acc.Withdraw(1000);
            acc.ComputeInterest();

            Console.Read();
        }
    }
}
