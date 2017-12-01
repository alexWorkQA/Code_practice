using NUnit.Framework;
using CodePractice.EasyLevel;

namespace UnitTestForCodePractice.EasyLevel
{
    [TestFixture]
    public class UnitTestTask03
    {
        [TestCase(15, 5, 1)]
        [TestCase(75, 7, 5)]
        public void PossitiveTestForTask03Easy(int number, int expectedLarge, int expectedSmall)
        {
            int actualSmall = EasyLevelTask03.getSmall(number);
            Assert.AreEqual(expectedSmall, actualSmall);
            int actualLarge = EasyLevelTask03.getLarge(number);
            Assert.AreEqual(expectedLarge, actualLarge);
        }
    }
}
