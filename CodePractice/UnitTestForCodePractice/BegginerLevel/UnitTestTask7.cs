using CodePractice.BeginnerLevel;
using NUnit.Framework;

namespace UnitTestForCodePractice.BegginerLevel
{
    [TestFixture]
    public class UnitTestTask7
    {
        [TestCase(5,5,7,new int[3] { 10,10,12})]
        [TestCase(6, 7, 7, new int[3] { 11, 12, 12 })]
        public void PossitiveDataDrivenForTask07Beginner(int num1,int num2, int num3, int [] expectedResult) 
        {
            int[] actualResult = BeginnerLevelTask07.InCreaseValues(num1,num2,num3);
        }
    }
}
