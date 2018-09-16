using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Без доп. переменных
            int a, b;
            a = 10;
            b = 7;
            a += b;
            b = a - b;
            a -= b;
            // С доп переменной
            a = 10;
            b = 7;
            int c;
            c = a;
            a = b;
            b = c;
        }
    }
}
