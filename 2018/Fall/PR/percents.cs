using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Практика "Проценты"; На вход даются сумма вклада,процентная ставка(в год) и срок (в месяцах);
 * Нужно найти накопившуюся сумма на момент окончания вклада
 */
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Принимаем данные от "пользователя" в формате строки и делим ее, чтобы вытащить числа
            string userInput = Console.ReadLine();
            Console.WriteLine(Program.Calculate(userInput));
            Console.ReadKey();
        }
        /* Создаем класс Calculate, который возвращает накопившуюся сумма на момент окончания вклада
         * путем вычисления члена геометрической прогрессии под номером period
         * depositSum = почти первый член последовательности,нужно лишь умножить на ставку
         * interestRate = знаменатель прогрессии = процентная ставка(почти)
         * period = номер члена последовательности, который нужно найти
         */
       public static double Calculate(string userInput)
        {
            /* Так как процентная ставка дается за год, а срок в месяцах, то нам нужна 1/12 часть процента
             * к тому же interestRate дается в процентах,
             * а нам нужен множитель(interestRate/1200 + 1 = множитель)
             */
            var parts = userInput.Split();
            double depositSum = double.Parse(parts[0]);
            double interestRate = (double.Parse(parts[1])/1200) + 1 ;
            double period = double.Parse(parts[2]);
            depositSum *= interestRate;
            return depositSum * Math.Pow(interestRate, period - 1);
        }
    }
}
