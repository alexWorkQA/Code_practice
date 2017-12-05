using System;

namespace CodePractice.EasyLevel
{
   public class EasyLevelTask02
    {
        public static double GetResult(int n, int k)
        {
            double resultValue = 0;
            for(int i = 0; i <= n; i++)
            {
                resultValue += Math.Pow(i, k);
            }
            return resultValue;
        }
    }
}
