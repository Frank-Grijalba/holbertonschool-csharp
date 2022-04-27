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
    }
}
