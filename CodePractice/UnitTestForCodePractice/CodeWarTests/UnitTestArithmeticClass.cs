using System;
using CodePractice.CodeWarsTasks;
using NUnit.Framework;

namespace UnitTestForCodePractice.CodeWarTests
{
    [TestFixture]
    public class UnitTestArithmeticClass
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(3, ArithmeticClass.Arithmetic(1, 2, "add"));
            Assert.AreEqual(6, ArithmeticClass.Arithmetic(8, 2, "subtract"));
            Assert.AreEqual(10, ArithmeticClass.Arithmetic(5, 2, "multiply"));
            Assert.AreEqual(4, ArithmeticClass.Arithmetic(8, 2, "divide"));
        }
    }
}
