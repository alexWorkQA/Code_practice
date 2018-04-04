using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.CodeWarsTasks
{
    public class Smiles
    {
        public static int CountSmileys(string[] smileys)
        {
            int count = 0;
            for (int i =0; i < smileys.Length;i++)
            {
                string smile = smileys[i];
                //count = 0;
                if (((smile.Length == 3) && (smile.IndexOf('-') == 1 || smile.IndexOf('~') == 1))) smile = smile.Remove(1,1);
                if (((smile.IndexOf(':') == 0 || smile.IndexOf(';') == 0)) && ((smile.IndexOf(')') == 1 || smile.IndexOf('D') == 1))) count++;
            }
            return count; 
            //smileys.Count(s => Regex.IsMatch(s, @"^[:;]{1}[~-]{0,1}[\)D]{1}$"));
        }
    }
}
