using NUnit.Framework;
using System.Collections.Generic;
using CodePractice.NormalLevel;

namespace UnitTestForCodePractice.NormalLevel
{
    [TestFixture]
    public class UnitTestTask11
    {
        [Test]
        public void PositiveTestForTask11Normal()
        {
            List<int> expectedResult = GenerateTestList();
            List<int> actualResult = NormalLevelTask11.GetOddValues(new int[6] { 6, 7, 9, 10, 11,12 });
            Assert.AreEqual(expectedResult, actualResult);
        }

        private List<int> GenerateTestList()
        {
            List<int> result = new List<int>();
            result.Add(7);
            result.Add(9);
            result.Add(11);
            return result;
        }
    }
}
