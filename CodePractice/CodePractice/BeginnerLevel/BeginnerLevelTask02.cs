namespace CodePractice.BeginnerLevel
{
    /// <summary>
    /// http://cppstudio.com
    /// Запрограммировать следующее выражение: 
    /// (а + b — f / а) + f * a * a — (a + b) 
    /// Числа а, b, f вводятся с клавиатуры.
    /// </summary>
    public class BeginnerLevelTask02
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="f"></param>
        /// <returns></returns>
        public static int CalculateFunction(int a, int b, int f)
        {
            return ((a+b -f/a)+f*a*a-(a+b));
        }
    }
}
