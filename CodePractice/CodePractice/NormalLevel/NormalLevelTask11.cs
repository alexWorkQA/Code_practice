using System;
using System.Collections.Generic;

namespace CodePractice.NormalLevel
{
    /// <summary>
    /// Дан массив размера n, заполнить его случайными числами, Найти все нечётные числа массива.
    /// </summary>
    public class NormalLevelTask11
    {
        private int [] GenerateArray(int n)
        {
            int[] arrayResult = new int[n];
            Random rnd = new Random();
            for(int i = 0; i<n; i++)
            {
                arrayResult[i] = rnd.Next();
            }
            return arrayResult;
        }

        public static List<int> GetOddValues(int [] arrayIn)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < arrayIn.Length; i++)
            {
                if (arrayIn[i] % 2 != 0) result.Add(arrayIn[i]);
            }
            return result;
        }
    }
}
