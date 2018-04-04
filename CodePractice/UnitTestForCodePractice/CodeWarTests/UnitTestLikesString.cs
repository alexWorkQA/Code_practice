using System;
using NUnit.Framework;
using CodePractice.CodeWarsTasks;

namespace UnitTestForCodePractice.CodeWarTests
{
    [TestFixture]
    public class SolutionTest
    {
        [Test, Description("It should return correct text")]
        public void LikesMethodTest()
        {
            Assert.AreEqual("no one likes this", LikesString.Likes(new string[0]));
            Assert.AreEqual("Peter likes this", LikesString.Likes(new string[] { "Peter" }));
            Assert.AreEqual("Jacob and Alex like this", LikesString.Likes(new string[] { "Jacob", "Alex" }));
            Assert.AreEqual("Max, John and Mark like this", LikesString.Likes(new string[] { "Max", "John", "Mark" }));
            Assert.AreEqual("Alex, Jacob and 2 others like this", LikesString.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));
        }
    }
}
