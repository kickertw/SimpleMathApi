using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleMath.Core;

namespace SimpleMath.MsTests
{
    [TestClass]
    public class CoreUnitTests
    {
        [TestMethod]
        public void AddTest()
        {
            var retVal = Calculator.Add(1, 2);
            Assert.AreEqual(3, retVal);
        }

        [TestMethod]
        public void DiffTest()
        {
            var retVal = Calculator.Subtract(2, 1);
            Assert.AreEqual(1, retVal);
        }

        [TestMethod]
        public void IsNegTest()
        {
            var retVal = Calculator.IsNegative(3);
            Assert.IsFalse(retVal);
        }
    }
}
