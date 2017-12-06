namespace CodePractice.NormalLevel
{
    /// <summary>
    /// Задана матрица А размерностью nxm. Записать все элементы матрицы в одномерный массив.
    /// </summary>
    public class NormalLevelTask15
    {

        public static int [] ConvertArrays(int [,] inTwoDimArray)
        {
            int n = inTwoDimArray.GetLength(0);
            int m = inTwoDimArray.GetLength(1);
            int[] resultArray = new int[n * m];
            int a = 0; 
            for (int i = 0; i<n; i++)
                for(int j =0; j < m; j++)
                {
                    resultArray[a] = inTwoDimArray[i, j];
                    a++;
                }
            return resultArray;
        }
    }
}
