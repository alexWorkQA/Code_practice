using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.CodeWarsTasks
{
    public class ArithmeticClass
    {
        public static double Arithmetic(double v1, double v2, string op)
        {
            switch (op)
            {
                case "add": return v1 + v2;
                case "subtract": return v1 - v2;
                case "multiply": return v1 * v2;
                case "divide": return v1 / v2;
                default: throw new System.InvalidOperationException("Invalid operation.");
            }
        }
    }
}
