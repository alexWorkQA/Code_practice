using System;

namespace CodePractice.BeginnerLevel
{
    /// <summary>
    /// http://cppstudio.com
    /// Составить программу, которая требует ввести два числа. Если первое число больше второго, то программа печатает слово больше.
    /// </summary>
    public class BeginnerLevelTask06
    {
        public static string LargeOrLess(int num1, int num2)
        {
            if (num1 < num2) return "less";
            else return "large";
        }
    }
}
