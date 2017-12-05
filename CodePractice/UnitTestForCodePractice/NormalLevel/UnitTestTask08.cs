using CodePractice.NormalLevel;
using NUnit.Framework;

namespace UnitTestForCodePractice.NormalLevel
{
    [TestFixture]
    public class UnitTestTask08
    {
        [Test]
        public void PositiveTestForTask08NormalToUpperCase()
        {
            string expectedResult = "TEST MESSAGE";
            string actualResult = NormalLevelTask08.ToUpperCase("Test message");
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void PositiveTestForTask08NormalToLowerCase()
        {
            string expectedResult = "test message";
            string actualResult = NormalLevelTask08.ToLowerCase("Test Message");
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void PositiveTestForTask08NormalCamelCase()
        {
            string expectedResult = "Test The Message";
            string actualResult = NormalLevelTask08.CamelStyle("test the message");
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void PositiveTestForTask08NormalFirstNext()
        {
            string expectedResult = "tEST tHE mESSAGE";
            string actualResult = NormalLevelTask08.FirstLowerCaseNextUpperCase("Test The Message");
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
