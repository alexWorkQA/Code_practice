using NUnit.Framework;
using CodePractice.NormalLevel;
using CodePractice.Models;

namespace UnitTestForCodePractice.NormalLevel
{
    [TestFixture]
    public class UnitTestTask14
    {
        [Test]
        public void PositiveTestForTask14NormalCreateVaildWorker()
        {
            string nameWorker = "John";
            int experWorker = 2;
            int hourlyWagHoursWorker = 50;
            int workedHoursWorker = 1000;

            WorkerModelTask14Normal worker = NormalLevelTask14.GetValidWorker(nameWorker, experWorker, hourlyWagHoursWorker, workedHoursWorker);

            Assert.AreEqual(nameWorker, worker.Name);
            Assert.AreEqual(experWorker, worker.Experience);
            Assert.AreEqual(hourlyWagHoursWorker, worker.HourlyWag);
            Assert.AreEqual(workedHoursWorker, worker.WorkedHours);
        }
    }
}
