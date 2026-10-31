using System.Text;
using Tyuiu.YushkovAI.Sprint3.Task0.V9.Lib;

namespace Tyuiu.YushkovAI.Sprint3.Task0.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Юшков А. И. | ПКТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Юшков А. И. | ПКТб-26-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет                *");
            Console.WriteLine("* сумму ряда по формуле при x = 0,5                                       *");
            Console.WriteLine("* S = Sum(i=1..15) (1 / (3 + x^i))^i                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double Value = 0.5;

            int StartValue = 1;

            int StopValue = 15;

            Console.WriteLine($"Значение X = {Value}");

            Console.WriteLine($"Старт шага = {StartValue}");

            Console.WriteLine($"Стоп шага = {StopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.GetSumSeries(Value, StartValue, StopValue);

            Console.WriteLine($"Сумма ряда = {res}");
        }
    }
}