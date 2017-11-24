using CodePractice.BeginnerLevel;
using NUnit.Framework;

namespace UnitTestForCodePractice.BegginerLevel
{
    [TestFixture]
    public class UnitTestTask6
    {
        [TestCase(5,6,"less")]
        [TestCase(6,5,"large")]
        public void PossitiveDataDrivenForTask06(int num1, int num2, string expectedResult)
        {
            string actualResult = BeginnerLevelTask06.LargeOrLess(num1, num2);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
