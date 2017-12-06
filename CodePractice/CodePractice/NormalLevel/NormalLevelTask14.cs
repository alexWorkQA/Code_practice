using CodePractice.Models;
namespace CodePractice.NormalLevel
{
    /// <summary>
    /// Создать класс, описывающий понятие работник, со свойствами:
    /// фамилия;
    /// стаж;
    /// часовая заработная плата;
    /// количество отработанных часов.
    /// 
    /// Рассчитать с помощью методов заработную плату, за отработанное время, и премию, 
    /// размер которой определяется в зависимости от стажа (при стаже до 1 года 0%, до 3 лет 5%, до 5 лет 8%, свыше 5 лет 15%).
    /// Предусмотреть метод для записи в файл данных о работнике.
    /// </summary>
    public class NormalLevelTask14
    {
        //WorkerModelTask14Normal worker;
        public static WorkerModelTask14Normal GetValidWorker(string name, int experience, int hourlyWag, int workedHours )
        {
            WorkerModelTask14Normal worker;
            worker = new WorkerModelTask14Normal();
            worker.Name = name;
            worker.Experience = experience;
            worker.HourlyWag = hourlyWag;
            worker.WorkedHours = workedHours;
            return worker;
        }
        //Get Salary for exact worker
        public static double GetWorkersSalary(WorkerModelTask14Normal worker)
        {
            double resultSalary = worker.WorkedHours * worker.HourlyWag;
            return resultSalary;
        }

        //Get Premy for exact worker
        public static double GetWorkersPremy(WorkerModelTask14Normal worker)
        {
            double primeRate = 0.0d;
            if (worker.Experience <= 1) primeRate = 0;
            else
                if (worker.Experience > 1 && worker.Experience <= 3) primeRate = 5;
            else
                if (worker.Experience > 3 && worker.Experience <= 5) primeRate = 8;
            else
                primeRate = 15;

                double resultPrime = GetWorkersSalary(worker) * primeRate / 100;
            return resultPrime;
        }
    }
}
