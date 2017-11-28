using NUnit.Framework;
using CodePractice.EasyLevel;

namespace UnitTestForCodePractice.EasyLevel
{
    [TestFixture]
    public class UnitTestTask05
    {
        [TestCase(2,10,1024)]
        public void PossitiveTestForTask05(int num, int pow, long expectedResult)
        {
            long actualResult = EasyLevelTask05.GetPow(num, pow);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
