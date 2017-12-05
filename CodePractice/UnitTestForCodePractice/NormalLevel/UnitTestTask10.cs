using NUnit.Framework;
using CodePractice.NormalLevel;
using System.Collections.Generic;

namespace UnitTestForCodePractice.NormalLevel
{

    [TestFixture]
    public class UnitTestTask10
    {
        [Test]
        public void PositiveTestForTask10Normal()
        {
            Dictionary<char, int> expectedResult = new Dictionary<char, int>();
            expectedResult.Add('T', 1);
            expectedResult.Add('e', 4);
            expectedResult.Add('s', 3);
            expectedResult.Add('t', 3);
            expectedResult.Add(' ', 1);
            expectedResult.Add('m', 1);
            expectedResult.Add('a', 1);
            expectedResult.Add('g', 1);

            Dictionary<char, int> actualResult = NormalLevelTask10.GetCahrDictonary("Teesttt message");
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
