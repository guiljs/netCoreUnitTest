using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp4;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        Matematica matematica;

        [TestInitialize]
        public void InitializeTest()
        {
            matematica = new Matematica();
        }

        [DataTestMethod]
        [DataRow(0, 0, 0, DisplayName = "Tem que dar Zero")]
        [DataRow(1, 1, 2)]
        [DataRow(5, 5, 10)]
        [DataRow(-1, 1, 0)]
        [DataRow(1, -1, 0)]
        [DataRow(-1, -1, -2)]
        public void TestSoma(int a, int b, int resultExpected)
        {
            var result = matematica.Soma(a, b);
            Assert.AreEqual(resultExpected, result, $"{a} + {b} devia dar {resultExpected}");
        }

        [DataTestMethod]
        [DataRow(0, 0, 0)]
        [DataRow(1, 0, 1)]
        [DataRow(1, 1, 0)]
        [DataRow(1, -1, 2)]
        public void TestSubtrai(int a, int b, int resultExpected)
        {
            var result = matematica.Subtrai(a, b);

            Assert.AreEqual(resultExpected, result);
        }

        [TestMethod]
        public void TestFibonacci()
        {
            var result = matematica.Fibonacci(1);

            Assert.AreEqual(1, result);

        }

        [DataRow(0, 0)]
        [DataRow(1, 1)]
        [DataRow(2, 1)]
        [DataRow(5, 5)]
        [DataRow(10, 55)]
        [DataRow(80, 23416728348467685)]
        [DataTestMethod]
        public void TestFibonacciVarios(int a, long expectedResult)
        {
            var result = matematica.Fibonacci(a);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
