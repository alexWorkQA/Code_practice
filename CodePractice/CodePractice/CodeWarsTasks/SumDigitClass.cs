using System;
using System.Text.RegularExpressions;

namespace CodePractice.CodeWarsTasks
{
    public class SumDigitClass
    {
        public static int SumDigits(int number)
        {
            char[] chars = Regex.Replace(number.ToString(), @"[^0-9]", "").ToCharArray();
            int sum = 0;
            foreach (char ch in chars)
            {
                sum += (int)char.GetNumericValue(ch);
            }
            return sum; //(int)number.ToString().Sum(x => char.IsNumber(x) ? char.GetNumericValue(x) : 0);
        }
    }
}
