using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;
            int hourArrow = 10;
            int minuteArrow = 20;
            int angleHour = (hourArrow / 12) * 30;
            int angleMinute = (minuteArrow / 60) * 6;
            int absAngle1 = Math.Abs(angleMinute - angleHour);
            int absAngle2 = Math.Abs(angleHour - angleMinute);
            if (absAngle1<=absAngle2) 
            {
                answer = absAngle1;
            } else
            {
                answer = absAngle2;
            }
        }
    }
}
