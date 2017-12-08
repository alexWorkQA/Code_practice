using System;
namespace CodePractice.NormalLevel
{
    /// <summary>
    /// Дан текст, который пользователь должен ввести в программу, найти наибольшее количество идущих подряд букв.
    /// </summary>
    public class NormalLevelTask20
    {
        public static char[] GetCharArray(string message)
        {
            char[] charArray = message.ToCharArray();
           // Array.Sort(charArray);
            return charArray;
        }

        public static int GetCharsCount(char [] charArray)
        {
            int result = 0;
            int maxCount = 0;
            for (int i =1; i<=charArray.Length-1; i++)
            {
                if (charArray[i] == charArray[i - 1]) result++;
                else
                {
                    if (result > maxCount) { maxCount = result+1; result = 0; } else result = 0;
                }
            }
            return maxCount;
        }

    }
}
