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
        public void PossitiveDataDrivenForTask03(char incommingChar, char expectedResult)
        {
            char actualResult = BeginnerLevelTask03.CharToUpperCase(incommingChar);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
