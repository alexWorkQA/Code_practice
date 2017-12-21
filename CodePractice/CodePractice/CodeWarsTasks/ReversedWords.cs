using System;

namespace CodePractice.CodeWarsTasks
{
    /// <summary>
    /// Kata.ReverseWords("The greatest victory is that which requires no battle");
    /// should return "battle no requires which that is victory greatest The"
    /// </summary>
    public class ReversedWords
    {
        public static string ReverseWords(string str)
        {
            string result="";
            string[] words = str.Split(' ');
            Array.Reverse(words);
            for (int i = 0; i < words.Length-1; i++)
                result += words[i] + " ";
            return result+words[words.Length-1]; //string.Join(" ", str.Split(' ').Reverse());
        }
    }
}
