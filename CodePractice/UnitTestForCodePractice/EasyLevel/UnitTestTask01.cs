using CodePractice.EasyLevel;
using NUnit.Framework;

namespace UnitTestForCodePractice.EasyLevel
{
    [TestFixture]
    public class UnitTestTask01
    {
        
        double[,] CreateTestData()
        {
            double[,] testData = new double[3,4];
            //for 3 x
            testData[0,0] = 2.3d;
            testData[0,1] = 45.1d;
            testData[0,2] = 12.9d;
            testData[0,3] = 3.67d;

            testData[1,0] = 3.3d;
            testData[1,1] = 12.12d;
            testData[1,2] = 7d;
            testData[1,3] = 8d;

            testData[2,0] = 4d;
            testData[2,1] = 3d;
            testData[2,2] = 1.14d;
            testData[2,3] = 2d;

            return testData;
        }

        [Test]
        public void PossitiveTestForTask01Easy()
        {
            double[,] testDataForTest= CreateTestData();
            double actualResult = EasyLevelTask01.GetY(testDataForTest);
            Assert.AreEqual(541.51d,actualResult,0.1d);
        }
    }
}
