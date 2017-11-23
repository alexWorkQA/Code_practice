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
        public void DataDrivenTask2(int a,int b, int f, int expectedResult)
        {
            int actualResult = BeginnerLevelTask2.CalculateFunction(a,b,f);
            Assert.AreEqual(expectedResult,actualResult);
        }
    }
}
