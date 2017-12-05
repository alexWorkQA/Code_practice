using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.Models
{
    /// <summary>
    /// Worker model for Task14 Normal Level
    /// </summary>
    public class WorkerModelTask14Normal
    {
        string name;
        int experience;
        int hourlyWag;
        int workedHours;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Experience
        {
            get
            {
                return experience;
            }

            set
            {
                experience = value;
            }
        }

        public int HourlyWag
        {
            get
            {
                return hourlyWag;
            }

            set
            {
                hourlyWag = value;
            }
        }

        public int WorkedHours
        {
            get
            {
                return workedHours;
            }

            set
            {
                workedHours = value;
            }
        }
    }
}
