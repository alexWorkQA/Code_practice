namespace CodePractice.NormalLevel
{
    /// <summary>
    /// Используя показатели функции вычислить цепную дробь. Количество елементов дроби надо задавать с клавиатуры.
    ///1+1/(1+1/(1+1/(1+1/….)))
    /// </summary>
    public class NormalLevelTask02
    {
        public static double GetResult(int n)
        {
            double result = 1.0d;
            for(int i =0; i<n; i++)
            {
                result = 1 +  1 / result;
            }
            return result;
        }
    }
}
