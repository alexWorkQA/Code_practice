namespace CodePractice.NormalLevel
{
    /// <summary>
    /// Определить, является ли введённое число составным. 
    /// Составное число — число полученное путём произведения двух натуральных чисел, больших единицы.
    /// Ряд составных чисел: 4, 6, 8, 9, 10, 12, 14 и т. д.У ряда составных чисел есть одна особенность — 
    /// все составные числа делятся или на 2 или на 3 без остатка от деления.
    /// </summary>
    public class NormalLevelTask27
    {
        public static bool IsNumberDiff(int number)
        {
            if ((number % 2 == 0) || (number % 3 == 0))
                if ((number / 2 > 1) || (number / 3 > 1))
                    return true;
                else return false;
            else return false;
        }
    }
}
