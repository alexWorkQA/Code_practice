using System;

namespace CodePractice.BeginnerLevel
{
    /// <summary>
    /// http://cppstudio.com
    /// Составить алгоритм увеличения всех трех, введённых с клавиатуры, переменных на 5,
    /// если среди них есть хотя бы две равные. В противном случае выдать ответ «равных нет».
    /// </summary>
    public class BeginnerLevelTask07
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <returns></returns>
        public static int[] InCreaseValues(int num1, int num2, int num3)
        {
            int[] result = ToArray(num1, num2, num3);

            if (num1==num2 && num2==num3 && num1==num3)
            {
                for(int i =0; i < 3; i++)
                {
                    result[i] +=5;
                }
                return result;
            }
         
            else {
                return null; }
        }

        /// <summary>
        /// Generate an Array from params
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <returns></returns>
        private static int[] ToArray(int num1, int num2, int num3)
        {
            return new int[] { num1, num2, num3 };
        }
    }
}
