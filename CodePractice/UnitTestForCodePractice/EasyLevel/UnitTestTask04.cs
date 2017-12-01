using NUnit.Framework;
using CodePractice.EasyLevel;

namespace UnitTestForCodePractice.EasyLevel
{
    [TestFixture]
    public class UnitTestTask04
    {
        [Test]
        public void PossitiveTestForTask04Easy()
        {
            int velocity = 60;
            int time = 12;
            double expectedResult = 78.5217d;
            double actualResult = EasyLevelTask04.GetAngleA(velocity, time);
            Assert.AreEqual(expectedResult,actualResult,0.5d);
        }
    }
}
