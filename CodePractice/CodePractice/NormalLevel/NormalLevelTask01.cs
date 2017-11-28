using System;
using System.IO;

namespace CodePractice.NormalLevel
{
    /// <summary>
    /// В текстовом файле, содержащем текст программы на языке Си, 
    /// проверить соответствие открывающихся и закрывающихся фигурных скобок { и }. 
    /// Результат проверки вывести на экран и записать в виде фразы в текстовый файл. 
    /// Результат работы программы (вывод) поместить в отдельный текстовый файл (например, "out . txt " ), 
    /// продублировав на экране.
    /// </summary>
    public class NormalLevelTask01
    {

        public static string GetFileContent(string path)
        {
            FileInfo flInfo = new FileInfo(path);
            string fileContent = "";

            if (flInfo.Exists)
            {
                using (StreamReader stReader = new StreamReader(path))
                {
                    fileContent = stReader.ReadToEnd();
                }
            }
            return fileContent;
        }

        public static long GetFileLength(string path)
        {
            FileInfo flInfo = new FileInfo(path);
            string fileContent = "";
            if (flInfo.Exists)
            {
                using(StreamReader stReader = new StreamReader(path))
                {
                    fileContent = stReader.ReadToEnd();
                }
            }
                return fileContent.Length;
        }

        public static string CheckValid(string fileContent)
        {
            int opened = 0;
            int closed = 0;
            char[] chars = fileContent.ToCharArray();
            foreach(char ch in chars){
                if (ch == '{') opened++;
                if (ch == '}') closed++;
            }
            if (opened == closed) return "=="; else return "!=";
        }

        public static void WriteResultsToFile(string results)
        {
            throw new NotImplementedException();
        }

    }
}
