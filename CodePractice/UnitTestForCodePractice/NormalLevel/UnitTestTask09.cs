using NUnit.Framework;
using CodePractice.NormalLevel;

namespace UnitTestForCodePractice.NormalLevel
{
    [TestFixture]
    public class UnitTestTask09
    {
        [Test]
        public void JustTestItWorksTask09()
        {
            double[,] actualResult = NormalLevelTask09.GenerateDoubleRandomMatrix(3, 6);
            Assert.AreEqual(new double[10,10], actualResult);
        }
    }
}
