using NUnit.Framework;
using CodePractice.NormalLevel;


namespace UnitTestForCodePractice.NormalLevel
{
    
    [TestFixture]
    public class UnitTestTask23
    {
        static double[,] GetTestMatrix()
        {
            return new double[,] { { 23.0d, 34.2d, 23.2d }, { 12.0d, 23.5d, 22.0d }, { 11.0d, 12.0d, 20.0d }, { 00.0d, 00.1d, 00.0d }, { 21.0d, 22.0d, 24.0d } };
        }

        static string [] GetExpectedBestResult()
        {
            return new string[] {"Best result for sportsman № 0 is 34.2",
                "Best result for sportsman № 1 is 23.5",
                "Best result for sportsman № 2 is 20",
                "Best result for sportsman № 3 is 0.1",
                "Best result for sportsman № 4 is 24" };
        }


        [Test]
        public void PositiveTestForTask23NormalGetBestResult()
        {
            string[] actualResult = NormalLevelTask23.GetBestResult(GetTestMatrix());
            Assert.AreEqual(GetExpectedBestResult(), actualResult);
        }
    }
}
