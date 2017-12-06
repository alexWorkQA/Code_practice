using NUnit.Framework;
using CodePractice.NormalLevel;
using CodePractice.Models;

namespace UnitTestForCodePractice.NormalLevel
{
    [TestFixture]
    public class UnitTestTask14
    {
        WorkerModelTask14Normal worker;

        string nameWorker = "John";
        int experWorker = 2;
        int hourlyWagHoursWorker = 50;
        int workedHoursWorker = 2450;

        public WorkerModelTask14Normal CreateValidTestWorker()
        {
            worker = NormalLevelTask14.GetValidWorker(nameWorker, experWorker, hourlyWagHoursWorker, workedHoursWorker);
            return worker;
        }

        [Test]
        public void PositiveTestForTask14NormalCreateVaildWorker()
        {
            WorkerModelTask14Normal worker = CreateValidTestWorker();
            Assert.AreEqual(nameWorker, worker.Name);
            Assert.AreEqual(experWorker, worker.Experience);
            Assert.AreEqual(hourlyWagHoursWorker, worker.HourlyWag);
            Assert.AreEqual(workedHoursWorker, worker.WorkedHours);
        }

        [Test]
        public void PositiveTestForTask14NormalGetWorkersSalary()
        {
            WorkerModelTask14Normal worker = CreateValidTestWorker();
            double actualResult = NormalLevelTask14.GetWorkersSalary(worker);
            double expectedResult = 122500;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void PositiveTestTask14NormalGetWorkerPrime()
        {
            WorkerModelTask14Normal worker = CreateValidTestWorker();
            double actualResult = NormalLevelTask14.GetWorkersPremy(worker);
            double expectedResult = 6125;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
