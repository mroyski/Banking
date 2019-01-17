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
    }
}
