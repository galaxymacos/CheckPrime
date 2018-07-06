using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CheckPrime.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Solution solution = new Solution();
            bool result1 = solution.IsPrime(17);
            Assert.IsTrue(result1);
            bool result2 = solution.IsPrime(15);
            Assert.IsFalse(result2);
        }
    }
}
