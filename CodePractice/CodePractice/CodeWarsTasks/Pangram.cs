using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CodePractice.CodeWarsTasks
{
    public class Pangram
    {
        public static bool IsPangram(string str)
        {
            var list = new List<char>(Regex.Replace(str.ToUpper(), @"[^A-Z]", "").ToCharArray().Distinct());
            return list.Count == 26 ? true : false;
        }
    }
}
