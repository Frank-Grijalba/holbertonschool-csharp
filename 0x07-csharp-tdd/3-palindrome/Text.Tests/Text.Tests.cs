using NUnit.Framework;
using System;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            string phrase = "Anita lava la tina";
            Assert.IsTrue(Text.Str.IsPalindrome(phrase));

            string phrase1 = "A man, a plan, a canal: Panama.";
            Assert.IsTrue(Text.Str.IsPalindrome(phrase1));
        }
    }
}
