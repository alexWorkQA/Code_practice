using System;
using NUnit.Framework;
using CodePractice.BeginnerLevel;

namespace UnitTestForCodePractice.BegginerLevel
{
    [TestFixture]
    public class UnitTestTask2
    {
        [TestCase(15,10,3,675)]
        [TestCase(2,5,3,11)]
        public void PossitiveDataDrivenForTask02Beginner(int a,int b, int f, int expectedResult)
        {
            int actualResult = BeginnerLevelTask02.CalculateFunction(a,b,f);
            Assert.AreEqual(expectedResult,actualResult);
        }
    }
}
