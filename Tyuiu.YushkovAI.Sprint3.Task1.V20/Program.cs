using System.Text;
using Tyuiu.YushkovAI.Sprint3.Task1.V20.Lib;

namespace Tyuiu.YushkovAI.Sprint3.Task1.V20
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
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Юшков Антон Ильич | ПКТб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму ряда   *");
            Console.WriteLine("* по формуле S = Sum(k=1..16) (1 / cos(k))^2.                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int StartValue = 1;
            int StopValue = 16;

            Console.WriteLine($"Старт шага = {StartValue}");
            Console.WriteLine($"Стоп шага = {StopValue}");

            double res = ds.GetSumSeries(StartValue, StopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Сумма ряда = {res}");
        }
    }
}

