using NUnit.Framework;
using CodePractice.NormalLevel;

namespace UnitTestForCodePractice.NormalLevel
{
    [TestFixture]
    public class UnitTestTask16
    {
        static int [,] GetTestMatrix()
        {
            return new int[,] { { 8, 7, 2, 1 }, { 5, 4, 9, 2 }, { 1, 0, 2, 3 }, { 4, 2, 3, 4 } };
        }

        static int [,] GetSortedByRowTestMatrix()
        {
            return new int[,] { {8,7,2,1 }, {4,2,3,4 }, {1,0,2,3 }, {5,4,9,2 } };
        }

        static int [,] GetSortedByColumnTestMatrix()
        {
            return new int[,] { { 8,7,1,2 }, { 5,4,2,9 }, { 1,0,3,2 }, { 4,2,4,3 } };
        }

        static int [,] GetSortedTestMatrix()
        {
            return new int[,] { {8,7,1,2 }, { 4,2,4,3}, { 1,0,3,2}, { 5,4,2,9} };
        }

        [Test]
        public void PositiveTestForTask16NormalGetColumnIndex()
        {
            int[,] testMatrix = GetTestMatrix();
            int expectedResult = 2;
            int actualResult = NormalLevelTask16.GetIndexColumnMaxValue(testMatrix);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void PositiveTestForTask16NormalGetRowIndex()
        {
            int[,] testMatrix = GetTestMatrix();
            int expectedResult = 1;
            int actualResult = NormalLevelTask16.GetIndexRowMaxValue(testMatrix);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void PositiveTestForTask16NormalSortRows()
        {
            int[,] expectedResult = GetSortedByRowTestMatrix();
            int[,] actualResult = NormalLevelTask16.SortRows(GetTestMatrix());
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void PositiveTestForTask16NormalSortColumns()
        {
            int[,] expectedResult = GetSortedByColumnTestMatrix();
            int[,] actualResult = NormalLevelTask16.SortColumns(GetTestMatrix());
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void PositiveTestForTask16NormalSortMatrix()
        {
            int[,] expectedResult = GetSortedTestMatrix();
            int[,] actualResult = NormalLevelTask16.GetSortedMatrix(GetTestMatrix());
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
