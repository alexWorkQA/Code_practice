using System;

namespace CodePractice.NormalLevel
{
    public class NormalLevelTask07
    {
        /// <summary>
        /// yi+1= 0.5 ( yi + 3 x / ( 2 yi2 + x / yi )).
        ///Начальное приближение y0=x.Итерации прекратить при |yi+1-yi|<(10-5). 
        ///Смысл данного задания — найти корень кубический без использования специальных функций.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        /// 

           
        public static double CbRt(double x)
        {
            double result = 0.0d;
            double y0 = x;
            double y1 = 0;
            bool mark = true;
            while (mark)
            {
                y1 = 0.5 * (y0 + 3 * x / (2 * Math.Pow(y0, 2) + x / y0));
                if (Math.Abs(y1 - y0) < Math.Pow(10, -5))
                {
                    mark = false;
                    result = y1;
                }
                y0 = y1;
            }
            return result;
        }
    }
}
