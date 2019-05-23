using System;
using Xunit;

namespace ATM_TDD.Tests
{
    public class AtmTests
    {
        //check balance should return 0 for balance
        [Fact]
        public void CheckBalance_Should_Return_Balance_Of_0()
        {
            // Arrange
            Atm underTest = new Atm();

            // Act
            int actualBalance = underTest.CheckBalance();

            // Assert
            Assert.Equal(0, actualBalance);
        }

        //check balance should return 200 for balance
        [Fact]
        public void CheckBalance_Should_Return_Balance_Of_200()
        {
            // Arrange
            Atm underTest = new Atm(200);

            // Act
            int actualBalance = underTest.CheckBalance();

            // Assert
            Assert.Equal(200, actualBalance);
        }

        //withdrawal should reduce balance by exactly 10 dollars
        [Fact]
        public void Withdraw_Should_Reduce_Balance_by_10_Dollars()
        {
            // Arrange
            Atm underTest = new Atm(200);

            // Act
            underTest.Withdraw();
            int actualBalance = underTest.CheckBalance();

            // Assert
            Assert.Equal(190, actualBalance);
        }

        //deposit should increase balance by exactly 50 dollars
        [Fact]
        public void Deposit_Should_Increase_Balance_by_50_Dollars()
        {
            // Arrange

            // Act

            // Assert
        }

    }
}
