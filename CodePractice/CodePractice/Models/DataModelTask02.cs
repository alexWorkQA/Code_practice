namespace UnitTestForCodePractice.Model
{
    public class DataModelTask02
    {
       public int[,] testDataMatrix;
       public int[] testDataVector;

        public DataModelTask02(int [,] testDataMatrix, int [] testDataVector)
        {
            this.testDataMatrix = testDataMatrix;
            this.testDataVector = testDataVector;
        }

        public static int [,] GenerateTestDataMatrix(int n, int m)
        {
            int[,] testDataMatrix = new int[n, m];

            //just for test testData filled by incremented value;
            int data = 1;

            for (int i =0; i < n; i++)
            {
                for (int j=0; j<m; j++)
                {
                    testDataMatrix[i, j] = data;
                    data++;
                }
            }
            return testDataMatrix;
        }

        public static int [] GenerateTestDataVector(int n)
        {
            int[] testDataVector = new int[n];
            int data = 1;
            for (int i =0; i < n; i++)
            {
                testDataVector[i] = data;
                data++;
            }
            return testDataVector;
        }
  }
}
