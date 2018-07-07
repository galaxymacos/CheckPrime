using System;
using NUnit.Framework;

namespace CheckPrime.UnitTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Solution solution = new Solution();
            int[] primes = {2, 3, 5, 7, 11, 13};
            foreach (var prime in primes)
            {
                var result = solution.IsPrimeMap(prime);
                Assert.That(result is true);
            }

            int[] nonPrimes = {4, 6, 8, 9, 10, 12};
            foreach (var nonPrime in nonPrimes)
            {
                var result = solution.IsPrimeMap(nonPrime);
                Assert.That(result is false);
            }
        }
    }
}