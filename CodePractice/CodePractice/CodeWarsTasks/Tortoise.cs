using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.CodeWarsTasks
{
    public class Tortoise
    {
        public static int[] Race(int v1,int v2,int g)
        {
            if (v1>=v2)
            return null;
            else
            {
                float time = (float)g / (v2 - v1);
                int timeSec = (int) (time * 3600);
                int h = timeSec / 3600;
                int min = (timeSec-h*3600) / 60;
                int sec = timeSec - min * 60 - h * 3600;
                return new int[] { h,min,sec};

               // if (v1 >= v2) return null;
               // var t = TimeSpan.FromHours((double)g / (v2 - v1));
               // return new[] { t.Hours, t.Minutes, t.Seconds };
            }
        }
    }
}
