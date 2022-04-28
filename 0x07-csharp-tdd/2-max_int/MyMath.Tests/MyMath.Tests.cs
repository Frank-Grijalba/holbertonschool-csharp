using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            List<int> newList = new List<int>(){
                98, -10, 0, 32, 972, 12, 1024, -727, -98, 50, 8
            };

            Assert.AreEqual(1024, Operations.Max(newList));

        }

        [Test]
        public void Test2()
        {
            List<int> newList = new List<int>();
            Assert.AreEqual(0, Operations.Max(null));
            Assert.AreEqual(0, Operations.Max(newList));
            newList.Add(5);
            newList.Add(4);
            Assert.AreEqual(5, Operations.Max(newList));
        }
    }
}