using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.NormalLevel
{
    public class NormalLevelTask08
    {
        /// <summary>
        /// Программа должна выполнять преобразования строки (длина строки 255 символов):
        /// 1.СТРОКА ЗАГЛАВНЫМИ БУКВАМИ
        /// 2.строка в нижнем регистре
        /// 3.С Заглавной Буквы(Первый Символ Каждого Слова В Строке)
        ///4. пЕРВЫЙ сИМВОЛ в нИЖНЕМ рЕГИСТРЕ
        ///5.Как в предложении(с заглавной буквы).
        /// </summary>
        /// <param name="charArray"></param>
        /// <returns></returns>
        /// 



        public static string ToUpperCase(string strMessage)
        {
            char [] charArray = strMessage.ToCharArray();
            string result="";
            foreach(char ch in charArray)
            {
                if (((byte) ch>=97) && ((byte) ch <= 122))
                {
                    result += (char)(ch - 32);
                }
                else
                {
                    result += ch;
                }
            }
            return result;
        }

        public static string ToLowerCase(string strMessage)
        {
            char[] charArray = strMessage.ToCharArray();
            string result = "";
            foreach (char ch in charArray)
            {
                if (((byte)ch >= 65) && ((byte)ch <= 90))
                {
                    result += (char)(ch + 32);
                }
                else
                {
                    result += ch;
                }
            }
            return result;
        }

        public static string CamelStyle(string strMessage)
        {
            string resultString = "";
            string[] separators = { " ", ",", ".", "-", "!" };
            string[] wordsInMessage = strMessage.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in wordsInMessage)
            {
                string wordRes = word;
                wordRes= wordRes.Substring(0, 1).ToUpper() + wordRes.Remove(0, 1) + " ";
                resultString += wordRes;
            }
            return resultString.Trim();
        }

        private static string RevertCase(string strMessage)
        {
            char[] charArray = strMessage.ToCharArray();
            string result = "";
            foreach (char ch in charArray)
            {
                if (((byte)ch >= 65) && ((byte)ch <= 90))
                {
                    result += (char)(ch + 32);
                }
                else
                if (((byte)ch >= 97) && ((byte)ch <= 122))
                {
                    result += (char)(ch-32);
                }
            }
            return result;
        }

        public static string FirstLowerCaseNextUpperCase(string strMessage)
        {
            strMessage = CamelStyle(strMessage);
            string resultString = "";
            string[] separators = { " ", ",", ".", "-", "!" };
            string[] wordsInMessage = strMessage.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in wordsInMessage)
            {
                string wordRes = word;
                wordRes = RevertCase(wordRes) + " ";
                resultString += wordRes;
            }
            return resultString.Trim();
        }

    }
}
