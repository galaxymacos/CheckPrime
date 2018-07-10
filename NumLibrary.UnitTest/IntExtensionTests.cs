using System;
using NUnit.Framework;

namespace NumLibrary.UnitTest
{
    [TestFixture]
    public class IntExtensionTests
    {
        private IntExtension intExtension;

        [SetUp]
        public void SetUp()
        {
            intExtension = new IntExtension();            
        }
        
        [Test]
        [TestCase(-2,false)]
        [TestCase(2,true)]
        [TestCase(3,true)]
        [TestCase(4,false)]
        [TestCase(5,true)]
        [TestCase(6,false)]
        public void IsPrimeMap_whenCalled_ReturnIfItIsAPrime(int num,bool expectedResult)
        {
            var result = intExtension.IsPrimeMap(num);
            Assert.That(result,Is.EqualTo(expectedResult));
        }
        
        [Test]
        [TestCase(-2,false)]
        [TestCase(2,true)]
        [TestCase(3,true)]
        [TestCase(4,false)]
        [TestCase(5,true)]
        [TestCase(6,false)]
        public void IsPrime_whenCalled_ReturnIfItIsAPrime(int num,bool expectedResult)
        {
            var result = intExtension.IsPrime(num);
            Assert.That(result,Is.EqualTo(expectedResult));
        }
    }

}