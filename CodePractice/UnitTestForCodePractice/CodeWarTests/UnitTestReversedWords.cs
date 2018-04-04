namespace Solution
{
    using NUnit.Framework;
    using System;
    using CodePractice.CodeWarsTasks;

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("world! hello", ReversedWords.ReverseWords("hello world!"));
            Assert.AreEqual("this like speak doesn't yoda", ReversedWords.ReverseWords("yoda doesn't speak like this"));
            Assert.AreEqual("foobar", ReversedWords.ReverseWords("foobar"));
            Assert.AreEqual("ValidatePinClass editor", ReversedWords.ReverseWords("editor ValidatePinClass"));
            Assert.AreEqual("boat your row row row", ReversedWords.ReverseWords("row row row your boat"));
        }
    }
}
