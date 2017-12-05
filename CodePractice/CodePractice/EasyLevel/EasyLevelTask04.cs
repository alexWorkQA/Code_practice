using System;

namespace CodePractice.EasyLevel
{
    public class EasyLevelTask04
    {
        const double G = 9.81;
        public static double GetAngleA(int velocity, int time)
        {
            double resultAngle = (Math.Asin((G * time) / (2 * velocity)))*(180/Math.PI);
            return resultAngle;
        }
    }
}
