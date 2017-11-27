namespace CodePractice.EasyLevel
{
    public class EasyLevelTask03
    {
        public static int getSmall(int number)
        {
            int first = number / 10;
            int second = number % 10;
            if (first < second) return first;
            else return second;
        }

        public static int getLarge(int number)
        {
            int first = number / 10;
            int second = number % 10;
            if (first > second) return first;
            else return second;
        }
    }
}
