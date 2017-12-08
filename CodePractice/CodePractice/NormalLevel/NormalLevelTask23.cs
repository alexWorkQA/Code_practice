namespace CodePractice.NormalLevel
{
    /// <summary>
    /// Результаты соревнований по прыжкам в длину представлены в виде матрицы 5х3 
    /// (5 спортсменов по 3 попытки у каждого). Указать, какой спортсмен и в какой попытке показал наилучший результат.
    /// </summary>
    public class NormalLevelTask23
    {
        public static string [] GetBestResult (double [,] allResults)
        {
            string[] bestResults = new string[5];
            for (int i = 0; i < allResults.GetLength(0); i++)
            {
                double maxResult = 0;
                for (int j = 0; j < allResults.GetLength(1); j++)
                {
                    if (allResults[i, j] >= maxResult) maxResult = allResults[i, j];
                }
                bestResults[i] = "Best result for sportsman № " + i +" is " + maxResult;
            }
            return bestResults;
        }
    }
}
