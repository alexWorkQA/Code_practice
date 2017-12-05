using UnitTestForCodePractice.Model;

namespace CodePractice.NormalLevel
{
    /// <summary>
    /// Нужно вычислить произведение матрицы на вектор. В полученном векторе найти макисмальный  элемент.
    /// </summary>
    public class NormalLevelTask03
    {

        public static int [] GetResultMatrix(DataModelTask02 testData)
        {
            int[] resultMatrix = new int[testData.testDataVector.Length];
            int n = testData.testDataMatrix.GetLength(0);
            int m = testData.testDataMatrix.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j =0; j < m; j++)
                {
                    resultMatrix[i] += testData.testDataMatrix[i, j] * testData.testDataVector[i];
                }
            }
            return resultMatrix;
        }
        public static int GetMaxValue(int [] vector)
        {
            int maxValue = 0;
            for(int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > maxValue) maxValue = vector[i];
            }
            return maxValue;
        }
    }
}

