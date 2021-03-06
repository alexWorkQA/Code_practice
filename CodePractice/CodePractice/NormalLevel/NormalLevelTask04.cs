﻿using System;

namespace CodePractice.NormalLevel
{
    /// <summary>
    /// Задача на динамическое выделение памяти. 
    /// Изначально есть указатель на массив с одним элементом. 
    /// Пользователь вводит число. Если оно больше 0 записываем его в массив. 
    /// Далее пользователь вводит второе число, тут уже,  если оно больше 0, 
    /// надо пере выделять память для 2-х элементов массива и записать в массив второе число. 
    /// И так далее…  для 3-х элементов, для 4-х…  пока пользователь не введет отрицательное число.
    /// </summary>
    public class NormalLevelTask04
    {
        /// <summary>
        /// Increase Capacity 
        /// </summary>
        /// <param name="incommingArray"></param>
        /// <returns></returns>
        private static int [] IncreaseArrayCapacity(int [] incommingArray)
        {
            int[] array = new int[incommingArray.Length + 1];
            return array;
        }

        /// <summary>
        /// Copy param to new Array
        /// </summary>
        /// <param name="incommingArray"></param>
        /// <returns></returns>
        private static int[] CopyArrayToArray(int[] incommingArray)
        {
            int[] result = IncreaseArrayCapacity(incommingArray);
            for (int i = 0; i<incommingArray.Length; i++)
            {
                result[i] = incommingArray[i];
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="incommingArray"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int [] AddNewNumber(int [] incommingArray, int num)
        {
            if (num != 0)
            {
                int[] result = CopyArrayToArray(incommingArray);
                result[incommingArray.Length] = num;
                return result;
            }
            else 
            {
                return incommingArray;
            }

        }
    }
}
