using CodePractice.BeginnerLevel;
using NUnit.Framework;

namespace UnitTestForCodePractice.BegginerLevel
{
    [TestFixture]
    public class UnitTestTask4
    {
        [TestCase(15,0.015)]
        [TestCase(12,0.012)]
        public void PossitiveDataDrivenForTask04Beginner(int meters, double expectedResult)
        {
            double actualResult = BeginnerLevelTask04.FromMetersToKilometers(meters);
            Assert.AreEqual(expectedResult,actualResult);
        }
    }
}
