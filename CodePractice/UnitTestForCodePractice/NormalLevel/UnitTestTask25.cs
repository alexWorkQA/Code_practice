using NUnit.Framework;
using CodePractice.NormalLevel;

namespace UnitTestForCodePractice.NormalLevel
{
    [TestFixture]
    public class UnitTestTask25
    {
        [Test]
        public void PositiveTestForTask25NormalGetShortestWord()
        {
            string testMessage = "Test message which contains the shortest word";
            string actualResult = NormalLevelTask25.GetShortestWord(testMessage);
            Assert.AreEqual("the", actualResult);
        }
    }
}
