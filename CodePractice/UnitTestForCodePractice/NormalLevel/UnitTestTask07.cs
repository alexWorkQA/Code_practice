using CodePractice.NormalLevel;
using NUnit.Framework;

namespace UnitTestForCodePractice.NormalLevel
{
    [TestFixture]
    public class UnitTestTask07
    {
        [Test]
        public void PositiveTestTask07Normal ()
        {
            double x = 27;
            double expectedResult = 3;
            double actualResult = NormalLevelTask07.CbRt(x);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
