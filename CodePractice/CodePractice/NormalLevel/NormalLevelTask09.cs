using System;

namespace CodePractice.NormalLevel
{
    public class NormalLevelTask09
    {
        /// <summary>
        /// Составить программу, которая будет генерировать случайные числа в интервале [a;b] и заполнять ими двумерный массив размером 10 на 10.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// 
        public static double [,] GenerateDoubleRandomMatrix(int x, int y)
        {
            double[,] dataMatrix = new double[10, 10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j =0; j<10; j++)
                {
                    dataMatrix[i, j] = rnd.NextDouble() * (x - y) + y;
                }
            }
            return dataMatrix;
        }
    }
}
