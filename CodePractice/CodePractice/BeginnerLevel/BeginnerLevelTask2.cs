using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.BeginnerLevel
{
    /// <summary>
    /// http://cppstudio.com
    /// Запрограммировать следующее выражение: 
    /// (а + b — f / а) + f * a * a — (a + b) 
    /// Числа а, b, f вводятся с клавиатуры.
    /// </summary>
    public class BeginnerLevelTask2
    {
        public static int CalculateFunction(int a, int b, int f)
        {
            return ((a+b -f/a)+f*a*a-(a+b));
        }
    }
}
