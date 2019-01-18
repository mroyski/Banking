using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount account = new CheckingAccount();

            Console.WriteLine("Welcome to We Can Bank IT!");
            Console.WriteLine("Your account has $" + account.Balance);


            Console.WriteLine("Press return to exit");
            Console.ReadLine();
        }
    }
}
