using NUnit.Framework;
using CodePractice.NormalLevel;

namespace UnitTestForCodePractice.NormalLevel
{
    [TestFixture]
    public class UnitTestTask02
    {
        [TestCase(6,1.61538d)]
        public void PositiveTestForTask02(int n, double expectedResult)
        {
            double actualResult = NormalLevelTask02.GetResult(n);
            Assert.AreEqual(expectedResult, actualResult,0.02d);
        }
    }
}
