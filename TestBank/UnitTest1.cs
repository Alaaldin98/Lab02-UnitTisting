using System;
using Xunit;
using Test;

namespace TestBank
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(200, Program.Deposit(100));
        }
        [Theory]
        
        [InlineData(900, 1000)]
        public void CanDeposMulti(decimal input, decimal expectedOutput)
        {
            Assert.Equal(expectedOutput, Program.Deposit(input));
        }

        [Fact]
        public void CanWithdraw()
        {
            Assert.Equal(70, Program.Withdraw(30));
        }
        [Fact]
        public void ViewBalance()
        {
            Assert.Equal(70, Program.ViewBalance(70));
        }

        
    }
}
