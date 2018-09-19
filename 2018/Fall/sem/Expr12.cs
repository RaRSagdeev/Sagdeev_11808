using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Expr12, найти минимальное и максимальное возможное время,
в течение которого у пассажиров будут заложены уши. Сагдеев Радель. Задача "Комфорт пассажиров"
*/
namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int h, t, v, x;
            h = 10000;
            t = 500;
            v = 50;
            x = 10;
            int timeMax = t;
            double timeMin = (h - x * t) / (v - x);
            Console.WriteLine("Максимальное время:{0}, минимальное: {1}", timeMax, timeMin);
            Console.ReadKey();
        }
    }
}
