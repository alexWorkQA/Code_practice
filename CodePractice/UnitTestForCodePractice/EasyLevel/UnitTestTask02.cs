using NUnit.Framework;
using CodePractice.EasyLevel;

namespace UnitTestForCodePractice.EasyLevel
{
    [TestFixture]
    public class UnitTestTask02
    {
        [TestCase(5,2,55)]
        public void PossitiveTestForTask02(int n, int k, double expectedResult)
        {
            double actualResult = EasyLevelTask02.GetResult(n, k);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
