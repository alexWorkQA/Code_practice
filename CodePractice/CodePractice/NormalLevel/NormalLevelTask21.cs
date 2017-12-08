namespace CodePractice.NormalLevel
{
    /// <summary>
    /// Описать функцию аddRightDigit(d, k), которая должна добавлять к целому положительному числу К справа цифру D 
    /// (D — целочисленное значение в диапазоне 0-9, К — целочисленное значение, которое является одновременно входным параметром и модифицируемым значением).
    /// </summary>
    public class NormalLevelTask21
    {
        public static int AddRightDigit(int d, int k)
        {
            if (d >= 0 && d <= 9) return k * 10 + d; else return 0; 
        }
    }
}
