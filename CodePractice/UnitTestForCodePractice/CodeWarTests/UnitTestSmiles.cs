using System;
using NUnit.Framework;
using CodePractice.CodeWarsTasks;

namespace UnitTestForCodePractice.CodeWarTests
{
    [TestFixture]
    public class UnitTestSmiles
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(Smiles.CountSmileys(new string[] { ":D", ":~)", ";~D", ":)" }), 4);
            Assert.AreEqual(Smiles.CountSmileys(new string[] { ":)", ":(", ":D", ":O", ":;" }), 2);
            Assert.AreEqual(Smiles.CountSmileys(new string[] { ";]", ":[", ";*", ":$", ";-D" }), 1);
            Assert.AreEqual(Smiles.CountSmileys(new string[] { ";", ")", ";*", ":$", "8-D" }), 0);
        }
    }
}
