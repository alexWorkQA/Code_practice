using CodePractice.BeginnerLevel;
using NUnit.Framework;

namespace UnitTestForCodePractice
{
    [TestFixture]
    public class UnitTestTask1
    {

        [TestCase(19452, new int [5] {1,9,4,5,2})]
        [TestCase(19451, new int[5] { 1, 9, 4, 5, 1 })]
        [TestCase(19450, new int[5] { 1, 9, 4, 5, 0 })]
        public void PossitiveDataDrivenForTask01(int number, int [] expectedArray)
        {
            int[] actualArray = BeginnerLevelTask01.CreateArrayFromNumber(number);
            Assert.AreEqual(expectedArray, actualArray);
        }
    }
}
