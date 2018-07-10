using System.Collections.Generic;
using NUnit.Framework;

namespace NumLibrary.UnitTest
{
    [TestFixture]
    public class ArrayExtensionTests
    {
        public void GetLargest_whenCalled_ReturnTheLargestIntegerInList()
        {
            ArrayExtension arrayExtension = new ArrayExtension();
            int result = arrayExtension.GetLargest(new List<int> {-4, 2, 5, -3, 1});
            Assert.That(result is 5);
        }
    }
}