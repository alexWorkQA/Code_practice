using NUnit.Framework;
using CodePractice.NormalLevel;

namespace UnitTestForCodePractice.NormalLevel
{
    [TestFixture]
    public class UnitTestTask21
    {
        [TestCase(4,5,54)]
        [TestCase(2,12,122)]
        [TestCase(5, 122, 1225)]
        public void PositiveTestForTask21NornalAddRightDigit(int d, int k, int expectedResult)
        {
            int actualResult = NormalLevelTask21.AddRightDigit(d, k);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
