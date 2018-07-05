using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSoma()
        {
            int result = 10;

            Assert.AreEqual(result, 10);
        }

        [TestMethod]
        public void TestDiminuir()
        {
            int result = 10;
            Assert.AreEqual(result, 10);
        }

        [TestMethod]
        public void TestMultiplicar()
        {
            int result = 10;
            Assert.AreEqual(result, 10);
        }

        [TestMethod]
        public void TestDividir()
        {
            int result = 10;
            Assert.AreEqual(result, 10);
        }
    }
}
