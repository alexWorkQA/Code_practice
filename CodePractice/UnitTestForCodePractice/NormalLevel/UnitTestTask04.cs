using CodePractice.NormalLevel;
using NUnit.Framework;

namespace UnitTestForCodePractice.NormalLevel
{
    [TestFixture]
    public class UnitTestTask04
    {
        [TestCase(new int[] {1,2,3}, 4 , new int[] { 1,2,3,4})]
        [TestCase(new int[] {1,2,3}, 0 , new int[] { 1,2,3})]
        public void PossitiveTestForTask04Normal(int [] incommingArray, int num, int [] expectedResult)
        {
            int[] actualResult = NormalLevelTask04.AddNewNumber(incommingArray, num);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
