using NUnit.Framework;
using CodePractice.NormalLevel;

namespace UnitTestForCodePractice.NormalLevel
{
    [TestFixture]
    public class UnitTestTask01
    {
        [Test]
        public void PositiveTestForTask01Normal()
        {
            string path = "E:\\ЛПР\\Code_practice\\Code_practice\\CodePractice\\UnitTestForCodePractice\\TestDataSet\\NormalLevelTask01.txt";
            long fileLength = NormalLevelTask01.GetFileLength(path);
            Assert.AreEqual(58, fileLength);
            string fileContent = NormalLevelTask01.GetFileContent(path);
            string result = NormalLevelTask01.CheckValid(fileContent);
            Assert.AreEqual("==", result);
        }

        [Test]
        public void PositiveTestForTask01_2Normal()
        {
            string path = "E:\\ЛПР\\Code_practice\\Code_practice\\CodePractice\\UnitTestForCodePractice\\TestDataSet\\NormalLevelTask01_2.txt";
            long fileLength = NormalLevelTask01.GetFileLength(path);
            Assert.AreEqual(57, fileLength);
            string fileContent = NormalLevelTask01.GetFileContent(path);
            string result = NormalLevelTask01.CheckValid(fileContent);
            Assert.AreEqual("!=", result);
        }

    }
}
