using NUnit.Framework;
using CodePractice.NormalLevel;

namespace UnitTestForCodePractice.NormalLevel
{
    [TestFixture]
    public class UnitTestTask20
    {
        [Test]
        public void PositiveTestForTask20NormalCharArray()
        {
            char[] expectedResult = new char[] { 'e', 'X', 'A', 'B' };
            char[] actualResult = NormalLevelTask20.GetCharArray("eXAB");
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("aeeastiua",2)]
        [TestCase("aaeeeesssiit", 4)]
        [TestCase("Text contains many diffferent chars",3)]
        public void PositiveTestForTask20NormalGetCharCount(string message, int expectedResult)
        {
            int actualResult = NormalLevelTask20.GetCharsCount(NormalLevelTask20.GetCharArray(message));
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
