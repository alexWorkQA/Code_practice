﻿namespace CodePractice.EasyLevel
{
    public class EasyLevelTask06
    {
        public static string GetDay(int dayNumber)
        {
            string dayName ="";
            switch (dayNumber)
            {

                case 1:
                    {
                        dayName = "Monday";
                        break;
                    };
                case 2:
                    {
                        dayName = "Tuesday";
                        break;
                    };
                case 3:
                    {
                        dayName = "Wednesday";
                        break;
                    };
                case 4:
                    {
                        dayName = "Thursday";
                        break;
                    };
                case 5:
                    {
                        dayName = "Friday";
                        break;
                    };
                case 6:
                    {
                        dayName = "Saturday";
                        break;
                    };
                case 7:
                    {
                        dayName = "Sunday";
                        break;
                    };
                default: { dayName = "Wrong day";
                        break;
                    }
            }
            return dayName;
        }
    }
}
