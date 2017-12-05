using NUnit.Framework;
using CodePractice.NormalLevel;

namespace UnitTestForCodePractice.NormalLevel
{
    [TestFixture]
    public class UnitTestTask13
    {
        [TestCase("12:22:30", new int [3] {12,22,30})]
        public void PositiveTestForTask13NormalParser(string timeMessage, int [] expectedResult)
        {
            int[] actualResult = NormalLevelTask13.ParseStringTimeToArray(timeMessage);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(new int[3] {12,30,30 }, 45030)]
        public void PositiveTestForTask13NormalConverterFromTimeToSeconds(int [] timeArray, int expectedResult)
        {
            int actualResult = NormalLevelTask13.ConvertFromArrayTimeToIntSeconds(timeArray);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(45030, new int[] { 12,30,30})]
        public void PositiveTestForTask13NormalConvertFromSecondsToTimeArray(int seconds, int [] expectedResult)
        {
            int[] actualResult = NormalLevelTask13.ConvertFromSecondToTimeArray(seconds);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("12:30:30",30,"12:30:00")]
        public void PositiveTestForTask13MinusSecondsFromTime(string initialTime, int seconds, string expectedResult)
        {
            string actualResult = NormalLevelTask13.MinusSecondsFromTime(seconds, initialTime);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("12:30:30","12:30:00",30)]
        public void PositiveTestForTask13GetSecondsRange(string startTime, string endTime, int expecyedResult)
        {
            int actualResult = NormalLevelTask13.GetSecondsForPeriodOfTime(startTime, endTime);
            Assert.AreEqual(expecyedResult, actualResult);
        }
    }
}
