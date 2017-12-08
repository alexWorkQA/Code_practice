using NUnit.Framework;
using CodePractice.NormalLevel;

namespace UnitTestForCodePractice.NormalLevel
{
    [TestFixture]
    public class UnitTestTask27
    {
        [TestCase(4,true)]
        [TestCase(6, true)]
        [TestCase(8, true)]
        [TestCase(7, false)]
        public void PositiveTestForTask27NormalIsNumberDiff(int number, bool expectedResult)
        {
            bool actualResult = NormalLevelTask27.IsNumberDiff(number);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
