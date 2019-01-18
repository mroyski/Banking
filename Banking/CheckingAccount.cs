using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    public class CheckingAccount
    {
        // Property
                          //can get and set value
        public decimal Balance { get; set; }

        // Method
        public void Deposit(decimal amount)
        {
            //Balance = Balance + amount;
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
    }
}
