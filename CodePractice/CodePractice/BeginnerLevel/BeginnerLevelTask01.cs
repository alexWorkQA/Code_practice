using System;

namespace CodePractice.BeginnerLevel
{
    /// <summary>
    /// http://cppstudio.com
    /// Составить программу, которая будет считывать введённое пятизначное число. 
    /// После чего, каждую цифру этого числа необходимо вывести в новой строке.
    /// </summary>
    public class BeginnerLevelTask01
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int [] CreateArrayFromNumber(int number)
        {
            int[] array = new int[5];
            int del = 1;
            for (int i = 4; i>=0; i--)
            {
                array[i] = number % (del * 10) / del;
                del *= 10;
            }
            return array;
        }

    }
}
