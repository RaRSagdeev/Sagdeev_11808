using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Координаты точки
            int x0 = int.Parse(Console.ReadLine());
            int y0 = int.Parse(Console.ReadLine());
            //Координаты первой точки прямой
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            // Координаты второй точки прямой
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            // Решение
            double answer = (Math.Abs((y2 - y1) * x0 - (x2 - x1) * y0 + x2 * y1 - y2 * x1))/(Math.Sqrt((y2 - y1) * (y2 - y1) + (x2 - x1) * (x2 - x1)));
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
