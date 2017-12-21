using NUnit.Framework;
using System;
using CodePractice.CodeWarsTasks;

[TestFixture]
public class Tests
{
    [Test]
    public static void Test1()
    {
        Assert.AreEqual("emocleW", SpinningWords.SpinWords("Welcome"));
    }

    [Test]
    public static void Test2()
    {
        Assert.AreEqual("Hey wollef sroirraw", SpinningWords.SpinWords("Hey fellow warriors"));
    }

    [Test]
    public static void Test3()
    {
        Assert.AreEqual("This is a test", SpinningWords.SpinWords("This is a test"));
    }

    [Test]
    public static void Test4()
    {
        Assert.AreEqual("This is rehtona test", SpinningWords.SpinWords("This is another test"));
    }

    [Test]
    public static void Test5()
    {
        Assert.AreEqual("You are tsomla to the last test", SpinningWords.SpinWords("You are almost to the last test"));
    }

    [Test]
    public static void Test6()
    {
        Assert.AreEqual("Just gniddik ereht is llits one more", SpinningWords.SpinWords("Just kidding there is still one more"));
    }
}
