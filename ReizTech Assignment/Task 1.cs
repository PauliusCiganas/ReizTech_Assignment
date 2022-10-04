using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTech_Assignment
{
    public class Task_1
    {

        public static int Angle(int hour, int minute)
        {
            if (hour < 0 || minute < 0 ||
                hour > 12 || minute > 60)
                Console.Write("Wrong input!");

            if (hour == 12)
                hour = 0;

            if (minute == 60)
            {
                minute = 0;
                hour += 1;
                if (hour > 12)
                {
                    hour = hour - 12;
                }
            }

            int hourAngle = (int)(0.5 * (hour * 60 + minute));
            int minuteAngle = (6 * minute);

            int ngl = Math.Abs(hourAngle - minuteAngle);

            ngl = Math.Min(360 - ngl, ngl);
            Console.WriteLine("calculated angle is: " + ngl);

            return ngl;
        }
    }
}
