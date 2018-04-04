using System;
using NUnit.Framework;
using CodePractice.CodeWarsTasks;

namespace UnitTestForCodePractice.CodeWarTests
{
    [TestFixture]
    public class UnitTestPangramClass
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual(true, Pangram.IsPangram("The quick brown fox jumps over the lazy dog."));
            Assert.AreEqual(false,Pangram.IsPangram("Test") );
        }
    }
}
