using System;
using System.Collections;

namespace CodePractice.NormalLevel
{
    /// <summary>
    /// Организовать ввод строки, каждое слово в строке отделяется от других слов пробелами, 
    /// их может быть неограниченное количество. Найти самое короткое слово в строке.
    /// </summary>
    public class NormalLevelTask25
    {
        public static string GetShortestWord(string message)
        {
            string[] strArray = message.Split(' ');
            string shortestWord = strArray[0];
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i].Length<shortestWord.Length) shortestWord = strArray[i]; 
            }
            return shortestWord;
        }
    }
}
