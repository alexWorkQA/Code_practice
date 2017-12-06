using NUnit.Framework;
using CodePractice.NormalLevel;

namespace UnitTestForCodePractice.NormalLevel
{
    [TestFixture]
    public class UnitTestTask15
    {
        public int[,] GenerateTestMatrix(int n, int m)
        {
            int[,] testMatrix = new int[n, m];
            int a = 0;

            for (int i =0; i < n; i++)
                for(int j =0; j < m; j++)
                {
                    testMatrix[i, j] = a;
                    a++;
                }
            return testMatrix;
        }


        [Test]
        public void PositiveTestForTask15ConvertArrays()
        {
            int[] actualResult = NormalLevelTask15.ConvertArrays(GenerateTestMatrix(4, 4));
            int[] expectedResult = new int[16];
            for (int i =0; i<16; i++)
            {
                expectedResult[i] = i;
            }
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
