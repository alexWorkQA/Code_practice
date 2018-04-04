using System;
using System.Linq;

namespace CodePractice.CodeWarsTasks
{
    public class HighestAndLowest
    {
        public static string HighAndLow(string numbers)
        {
            string [] strNumbers = numbers.Split(' ');
            int[] numbersInt = new int[strNumbers.Length];
            for (int i = 0; i < strNumbers.Length; i++)
            {
                numbersInt[i] = Int32.Parse(strNumbers[i]);
            }
            int min = numbersInt[0];
            int max = numbersInt[0];
            for (int i =0; i < numbersInt.Length; i++)
            {
                if (numbersInt[i] > max) max = numbersInt[i];
                if (numbersInt[i] < min) min = numbersInt[i];
            }
            return (max + " " + min) ;

            // var parsed = numbers.Split().Select(int.Parse);
           // return parsed.Max() + " " + parsed.Min();
        }
    }
}
