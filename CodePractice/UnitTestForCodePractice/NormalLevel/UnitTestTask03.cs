using CodePractice.NormalLevel;
using NUnit.Framework;
using UnitTestForCodePractice.Model;

namespace UnitTestForCodePractice.NormalLevel
{
    [TestFixture]
    public class UnitTestTask03
    {
        [Test]
        public void PositiveTestForTask03Normal()
        {
            int[] expectedResult = new int[4] { 15, 80, 195, 360 };
            DataModelTask02 testData;

            int[,] testMatrix = DataModelTask02.GenerateTestDataMatrix(4, 5);
            int[] testVector = DataModelTask02.GenerateTestDataVector(4);
            testData = new DataModelTask02(testMatrix, testVector);

            int[] actualResult = NormalLevelTask03.GetResultMatrix(testData);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
