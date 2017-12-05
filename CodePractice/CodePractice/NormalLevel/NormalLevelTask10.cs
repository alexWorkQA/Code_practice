using System.Collections.Generic;

namespace CodePractice.NormalLevel
{
    public class NormalLevelTask10
    {
        // IDictionary<char, int> arrayChar = new Dictionary<char,int>();
        /// <summary>
        /// Подсчитать количество повторений элементов, заданного множества символов, во введенной строке.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static Dictionary<char,int> GetCahrDictonary(string message)
        {
          Dictionary<char, int> result = new Dictionary<char, int>();
          for (int i =0; i<message.Length; i++)
            {
                if (!result.ContainsKey(message[i]))
                {
                    result.Add(message[i], 1);
                }
                else
                {
                    result[message[i]] ++;
                }
            }
            return result;
        }
    }
}
