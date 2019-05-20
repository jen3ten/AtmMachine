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
            Atm sut = new Atm();

            int actualBalance = sut.CheckBalance();

            Assert.Equal(0, actualBalance);
      
        }

        //check balance should return 200 for balance
        [Fact]
        public void CheckBalance_Should_Return_Balance_Of_200()
        {
            Atm sut = new Atm(200);

            int actualBalance = sut.CheckBalance();

            Assert.Equal(200, actualBalance);
        }

        //withdrawal should reduce balance by exactly 10 dollars
        [Fact]
        public void Withdraw_Should_Reduce_Balance_by_10_Dollars()
        {
            Atm sut = new Atm(200);

            sut.Withdraw();
            int actualBalance = sut.CheckBalance();

            Assert.Equal(190, actualBalance);
        }

        //deposit should increase balance by exactly 50 dollars
        [Fact]
        public void Deposit_Should_Increase_Balance_by_50_Dollars()
        {
            Atm sut = new Atm(200);

            sut.Deposit();
            int actualBalance = sut.CheckBalance();

            Assert.Equal(250, actualBalance);
        }

    }
}
