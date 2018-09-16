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
            int x = int.Parse(Console.ReadLine());
            int xReversed;
            xReversed = 100 * (x % 10) + 10 * ((x % 100) / 10) + x / 100;
            Console.WriteLine(xReversed);
            Console.ReadKey();
        }
    }
}
