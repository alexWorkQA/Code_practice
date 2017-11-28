using NUnit.Framework;
using CodePractice.EasyLevel;

namespace UnitTestForCodePractice.EasyLevel
{
    [TestFixture]
    public class UnitTestTask07
    {
        [TestCase(5,5,5,8.66025)]
        public void PossitiveTestForTask07(int x, int y, int z, double expectedResult)
        {
            double actualResult = EasyLevelTask07.GetVectorValue(x, y, z);
            Assert.AreEqual(expectedResult, actualResult,0.01d);
        }
    }
}
