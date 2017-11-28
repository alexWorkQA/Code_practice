namespace CodePractice.EasyLevel
{
    public class EasyLevelTask05
    {
        public static long GetPow(int num, int pow)
        {
            long result = 1;
            for(int i = 1; i<=pow; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}
