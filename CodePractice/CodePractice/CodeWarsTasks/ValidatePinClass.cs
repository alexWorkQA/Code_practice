using System;
using System.Text.RegularExpressions;

namespace CodePractice.CodeWarsTasks
{
    public class ValidatePinClass
    {
        public static bool ValidatePin(string pin)
        {
            string pattern = @"\d{4}|\d{6}";  //@^(\d{4}|\d{6})$
            if ((pin.Length == 4 || pin.Length == 6) && Regex.IsMatch(pin,pattern)) return true; else return false;
        }
    }
}
