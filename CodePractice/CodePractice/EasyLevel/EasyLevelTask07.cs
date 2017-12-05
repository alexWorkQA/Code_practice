using System;

namespace CodePractice.EasyLevel
{
    public class EasyLevelTask07
    {
        public static double GetVectorValue(int x, int y, int z)
        {
            double VectorValue = Math.Sqrt(x * x + y * y + z * z);
            return VectorValue;
        }
    }
}
