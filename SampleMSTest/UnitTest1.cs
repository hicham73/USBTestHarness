using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SuccesTestMethod()
        {
            int num = 20;
            int denom = 4;

            int quotient = num / denom;

            Assert.AreEqual(quotient, 5);
        }
        [TestMethod]
        public void FailureTestMethod()
        {
            int num = 20;
            int denom = 4;

            int quotient = num / denom;

            Assert.AreEqual(quotient, 6);
        }
    }
}
