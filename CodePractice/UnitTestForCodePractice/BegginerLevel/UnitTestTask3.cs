using System;
using NUnit.Framework;
using CodePractice.BeginnerLevel;

namespace UnitTestForCodePractice.BegginerLevel
{
    [TestFixture]
    public class UnitTestTask3
    {
        [TestCase('f','F')]
        [TestCase('a', 'A')]
        [TestCase('b', 'B')]
        public void PositiveDataDrivenForTask03Beginner(char incommingChar, char expectedResult)
        {
            char actualResult = BeginnerLevelTask03.CharToUpperCase(incommingChar);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
