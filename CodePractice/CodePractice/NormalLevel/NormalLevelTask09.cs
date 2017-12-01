using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.NormalLevel
{
    public class NormalLevelTask09
    {
        /// <summary>
        /// 
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
