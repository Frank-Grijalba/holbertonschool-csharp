using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(-1, Str.UniqueChar(""));
            Assert.AreEqual(1, Str.UniqueChar("abecedario"));
            Assert.AreEqual(2, Str.UniqueChar("aaron"));
            Assert.AreEqual(0, Str.UniqueChar("abbccdd"));
            
        }
    }
}
