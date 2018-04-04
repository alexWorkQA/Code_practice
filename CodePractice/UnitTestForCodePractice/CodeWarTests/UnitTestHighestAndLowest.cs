using System;
using NUnit.Framework;
using CodePractice.CodeWarsTasks;

namespace UnitTestForCodePractice.CodeWarTests
{
    [TestFixture]
    public class UnitTestHighestAndLowest
    {
        [Test]
        public void HighestAndLowestUnitTest()
        {
            Assert.AreEqual("42 -9", HighestAndLowest.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }
    }
}
