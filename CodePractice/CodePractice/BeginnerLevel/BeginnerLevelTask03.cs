namespace CodePractice.BeginnerLevel
{
    /// <summary>
    /// http://cppstudio.com
    /// Напишите программу, которая позволяет пользователю 
    /// ввести в консоли латинскую букву нижнего регистра,  переводит её в верхний регистр
    /// </summary>
    public class BeginnerLevelTask03
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ch"></param>
        /// <returns></returns>
        public static char CharToUpperCase(char ch)
        {
            if (ch >= 97 && ch <= 122)
                return (char)(ch - 32);
            else
                return ' ';
        }
    }
}
