namespace CodePractice.NormalLevel
{
    /// <summary>
    /// Выполнить преобразование матрицы, а именно — перестановку строк и столбцов. 
    /// Для  квадратной матрицы размером n переставляйте столбцы и строки таким образом, 
    /// чтобы элемент матрицы с наибольшим значением, по модулю, располагался в нижнем правом углу матрицы.
    /// </summary>
    public class NormalLevelTask16
    {
        //Get index of Column where max element is located
        public static int GetIndexColumnMaxValue(int [,] inMatrix)
        {
            int n = inMatrix.GetLength(0);
            int maxColumnIndex = 0;
            int maxValue = 0;
            for (int i = 0; i<n;i++)
                for (int j = 0; j < n; j++)
                {
                    if (inMatrix[i, j] > maxValue)
                    {
                        maxValue = inMatrix[i, j];
                        maxColumnIndex = j;
                    }
                }
            return maxColumnIndex;
        }

        //Get index of Row where max element is located
        public static int GetIndexRowMaxValue(int[,] inMatrix)
        {
            int n = inMatrix.GetLength(0);
            int maxRowIndex = 0;
            int maxValue = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (inMatrix[i, j] > maxValue)
                    {
                        maxValue = inMatrix[i, j];
                        maxRowIndex = i;
                    }
                }
            return maxRowIndex;
        }

        //Change Row with Max element and last Row
        public static int [,] SortRows(int [,] inMatrix)
        {
            int n = inMatrix.GetLength(0);
            int[,] sortedMatrix = inMatrix;
            int rowIndex = GetIndexRowMaxValue(inMatrix);
            int[] bufferArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                bufferArray[i] = sortedMatrix[n-1, i];
                sortedMatrix[n-1, i] = sortedMatrix[rowIndex, i];
                sortedMatrix[rowIndex, i] = bufferArray[i];
            }
            return sortedMatrix;
        }


        //Change Columns with Max element and last Column
        public static int[,] SortColumns(int[,] inMatrix)
        {
            int n = inMatrix.GetLength(0);
            int[,] sortedMatrix = inMatrix;
            int columnIndex = GetIndexColumnMaxValue(inMatrix);
            int[] bufferArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                bufferArray[i] = sortedMatrix[i, n-1];
                sortedMatrix[i, n-1] = sortedMatrix[ i, columnIndex];
                sortedMatrix[ i , columnIndex] = bufferArray[i];
            }
            return sortedMatrix;
        }

        //Get sorted matrix
        public static int [,] GetSortedMatrix (int [,] inMatrix)
        {
            int [,] sortedMatrix = SortColumns(inMatrix);
            sortedMatrix = SortRows(sortedMatrix);
            return sortedMatrix;
        }
    }
}
