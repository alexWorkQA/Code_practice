using System;

namespace CodePractice.NormalLevel
{
    /// <summary>
    /// Время задается в формате час, минута, секунда. Реализовать:
    /// 1) вычитание из времени указанного пользователем количества секунд;
    /// 2) подсчёт числа секунд между двумя моментами времени, лежащими в пределах одних суток.
    /// </summary>
    public class NormalLevelTask13
    {
        //Parse incoming string (HH:MM:SS) to Time Array of In
        //[0] = HH
        //[1] = MM
        //[2] = SS
        public static int [] ParseStringTimeToArray (string time)
        {
            int[] resultTime = new int[3];
            char [] separator = new char[] { ':' };
            string[] strTime = time.Split(separator);
            if (resultTime.Length == strTime.Length)
            {
                for (int i = 0; i < resultTime.Length; i++)
                    resultTime[i] = Int32.Parse(strTime[i]);
            }
            return resultTime;
        }

        //<summary>
        //Convert Time Array to int Seconds
        //</summary>
        public static int ConvertFromArrayTimeToIntSeconds(int[] arrayTime)
        {
            int resultSeconds = arrayTime[2] + arrayTime[1] * 60 + arrayTime[0] * 3600;
            return resultSeconds;
        }

        ///Convert int Seconds to Time Array
        public static int [] ConvertFromSecondToTimeArray(int seconds)
        {
            int[] resultTimeArray = new int[3];
            resultTimeArray[0] = seconds / 3600;
            resultTimeArray[1] = (seconds - resultTimeArray[0] * 3600)/60;
            resultTimeArray[2] = seconds - resultTimeArray[0] * 3600 - resultTimeArray[1] * 60;
            return resultTimeArray;
        }

        //Method Subtracts seconds from the initial value of Time
        public static string MinusSecondsFromTime(int seconds, string initialTime)
        {
            int[] timeArray = ParseStringTimeToArray(initialTime);
            int[] resultTimeArray = ConvertFromSecondToTimeArray(ConvertFromArrayTimeToIntSeconds(timeArray) - seconds);
            string resultTimeStr = ParseArrayTimeToString(resultTimeArray);
            return resultTimeStr;
        }

        //Parse method from Time Array to String
        public static string ParseArrayTimeToString(int [] timeArray)
        {
            string result = "";
            if (timeArray[0] != 0) result += timeArray[0]; else result += "00";
            result += ":";
            if (timeArray[1] != 0) result += timeArray[1]; else result += "00";
            result += ":";
            if (timeArray[2] != 0) result += timeArray[2]; else result += "00";
            return result;
        }
        //Get value of seconds beetwen to Times
        public static int GetSecondsForPeriodOfTime (string beginTime, string endTime)
        {
            int timeSecondsBegin = ConvertFromArrayTimeToIntSeconds(ParseStringTimeToArray(beginTime));
            int timeSecondsEnd = ConvertFromArrayTimeToIntSeconds(ParseStringTimeToArray(endTime));
            int timeSecondsResult = timeSecondsBegin - timeSecondsEnd;
            return timeSecondsResult;
        }
    }
}
