using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemExpr5
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer=0;
            int a, b;
            a = Console.Read();
            b = Console.Read();
            Console.Write("Its a " + a + b);
            if (a%4 + b%4 == 4)
            {
                answer = 1;
            }
            Console.WriteLine(answer);
            int ThousandDifference = b / 100 - a / 100;
            if (a%100 + b%100>100)
            {
                ThousandDifference += 1;
            }
            answer += (b - a) / 4 - ThousandDifference + ThousandDifference / 4;
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
