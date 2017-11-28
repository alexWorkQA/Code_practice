using NUnit.Framework;
using CodePractice.EasyLevel;

namespace UnitTestForCodePractice.EasyLevel
{
    [TestFixture]
    public class UnitTestTask06
    {
        [TestCase(1,"Monday")]
        [TestCase(7, "Sunday")]
        [TestCase(9, "Wrong day")]
        public void PossitiveTestForTask06(int dayName, string expectedResult)
        {
            string actualResult = EasyLevelTask06.GetDay(dayName);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
