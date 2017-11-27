using System;

namespace CodePractice.EasyLevel
{
    /// <summary>
    /// http://cppstudio.com
    /// Найти Y, если Y = X1 + X2 + … + Xn,   X = Z^3 - B + A^2 / tg(betta)^2. 
    /// Количество X вводятся пользователем программы. Для каждого X значения Z, B, А, betta разные
    /// </summary>
    public class EasyLevelTask01
    {
        public static double GetY(double[,] testData)
        {
            double result = 0.0d;
            for (int i = 0; i < 3; i++)
            {
                result += (Math.Pow(testData[i, 0],3) - testData[i, 1] + Math.Pow(testData[i, 2],2 ) / Math.Pow(Math.Tan(testData[i, 3]),2));
            }
            return result ;
        }
    }
}
