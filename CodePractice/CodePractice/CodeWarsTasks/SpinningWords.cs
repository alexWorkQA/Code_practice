using System;

namespace CodePractice.CodeWarsTasks
{
    public class SpinningWords
    {
        /// <summary>
        /// Write a function that takes in a string of one or more words, and returns the same string, 
        /// but with all five or more letter words reversed (Just like the name of this ValidatePinClass). 
        /// Strings passed in will consist of only letters and spaces. Spaces will be included only when more than one word is present.
        /// Examples:
        /// spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw"
        /// spinWords( "This is a test") => returns "This is a test" 
        /// spinWords( "This is another test" ) => returns "This is rehtona test"
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public static string SpinWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            string resultSentence="";
            for (int i = 0; i< words.Length; i++)
            {
                if (words[i].Length >= 5)
                {
                    words[i] = ReverseWord(words[i]);
                    resultSentence = resultSentence + words[i] + " ";
                }
                else
                {
                    resultSentence = resultSentence + words[i] + " ";
                }
            }
            return resultSentence.Trim();
        }

        static string ReverseWord (string message)
        {
            char[] charArray = message.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
