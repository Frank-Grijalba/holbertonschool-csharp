using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int result = Operations.Add(5, 10);
            Assert.AreEqual(15, result);
        }

        [Test]
        public void Test2()
        {
            int result = Operations.Add(3, 4);
            Assert.AreEqual(7, result);
        }
    }
}
