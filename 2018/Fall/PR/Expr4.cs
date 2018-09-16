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
            int y = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int answer = (N - 1) / y + (N - 1) / x - (N - 1) / (x * y);
            Console.WriteLine(answer);
        }
    }
}
