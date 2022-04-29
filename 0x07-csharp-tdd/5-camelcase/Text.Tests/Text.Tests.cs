using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, Str.CamelCase("frank"));
            Assert.AreEqual(4,Str.CamelCase("isANewChallenge"));
            Assert.AreEqual(0, Str.CamelCase(""));
            Assert.AreEqual(0,Str.CamelCase(null));
        }
    }
}
