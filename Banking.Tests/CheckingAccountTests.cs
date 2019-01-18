using System;
using Xunit;

namespace Banking.Tests
{
    public class CheckingAccountTests
    {
        [Fact]
                    // Describes what test is testing
        public void Balance_Starts_At_Zero()
        {
            // Act
            // Creating a new checking account
            CheckingAccount account = new CheckingAccount();

            // Assert
            // Balance starts at 0
            Assert.Equal(0M, account.Balance);
        }

        [Fact]
        public void Deposit_Increases_Balance()
        {
            // Arrange
            CheckingAccount account = new CheckingAccount();

            // Act
            account.Deposit(200M);

            // Assert
                          //(expected, actual)
            Assert.Equal(200M, account.Balance);
        }

        [Fact]
        public void Withdraw_Decreases_Balance()
        {
            CheckingAccount account = new CheckingAccount();

            account.Deposit(250M);

            account.Withdraw(100M);

            Assert.Equal(150M, account.Balance);
        }

        //[Fact]
        //// Creating variables
        //public void Foo()
        //{
        //    int age; // Declare
        //    age = 35; // Assign
        //    int graduationYear = 2002; // Initialize

        //    Console.WriteLine(age);
        //    Console.WriteLine(graduationYear);
        //}
    }
        
}
