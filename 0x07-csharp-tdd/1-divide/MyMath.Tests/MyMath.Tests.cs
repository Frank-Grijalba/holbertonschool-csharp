using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int[,] myMatrix = new int[,]{
            {0, 1, 2},
            {3, 4, 5},
            {6, 7, 8}
            };

            
            Assert.AreEqual(null, Matrix.Divide(myMatrix, 0));    
        }

        [Test]
        public void Test2()
        {
            int[,] myMatrix = new int[,]{
            {0, 1, 2},
            {3, 4, 5},
            {6, 7, 8}
            };
            
            Assert.AreEqual(1, Matrix.Divide(myMatrix, 4)[1,1]);
        }

        [Test]
        public void Test3()
        {
            int[,] myMatrix = new int[,]{
            {0, 1, 2},
            {3, 4, 5},
            {6, 7, 8}
            };

            Assert.AreEqual(null, Matrix.Divide(null, 3));
        }
    }
}
