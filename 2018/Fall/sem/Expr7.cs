using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ggt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Коэфф. k уравнения прямой kx+b;
            int k = int.Parse(Console.ReadLine());
            // Коэфф. смещения графика b
            int b = int.Parse(Console.ReadLine());
            // Переменная х
            int x = 10; 
            int MainLine = k * x + b;
            int parallelLine = k * x + (b + 1);
            int perpendicLine = - 1/k * x + b;
        }
    }
}
