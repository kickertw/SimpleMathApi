using System;
using SimpleMath.Core;
using Xunit;

namespace SimpleMath.XUnitTests
{
    public class CoreUnitTests
    {
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(-1, 1, 0)]
        [InlineData(-1, -10, -11)]
        public void AddTest(int a, int b, int expected)
        {
            var retVal = Calculator.Add(a, b);
            Assert.Equal(expected, retVal);
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(-1, 1, -2)]
        [InlineData(-1, -10, 9)]
        public void DiffTest(int a, int b, int expected)
        {
            var retVal = Calculator.Subtract(a, b);
            Assert.Equal(expected, retVal);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(-1, 1, -1)]
        [InlineData(-1, -10, 10)]
        public void MultTest(int a, int b, int expected)
        {
            var retVal = Calculator.Mult(a, b);
            Assert.Equal(expected, retVal);
        }

        [Theory]
        [InlineData(-10)]
        [InlineData(-1)]
        public void IsNegTest(int a)
        {
            var retVal = Calculator.IsNegative(a);
            Assert.True(retVal);
        }
    }
}
