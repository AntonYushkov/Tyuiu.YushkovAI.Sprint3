using System.Text;
using Tyuiu.YushkovAI.Sprint3.Task5.V22.Lib;

namespace Tyuiu.YushkovAI.Sprint3.Task5.V22
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
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Юшков Антон Игоревич | ПКТб-26-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить двойную сумму при x = 2:                                      *");
            Console.WriteLine("* y = Sum(i=1..3) Sum(k=1..12) (x^3 * sin(k) + 2).                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            int StartValue1 = 1;
            int StartValue2 = 1;
            int StopValue1 = 3;
            int StopValue2 = 12;

            Console.WriteLine($"Значение x = {x}");
            Console.WriteLine($"Начало внешнего цикла = {StartValue1}");
            Console.WriteLine($"Конец внешнего цикла = {StopValue1}");
            Console.WriteLine($"Начало внутреннего цикла = {StartValue2}");
            Console.WriteLine($"Конец внутреннего цикла = {StopValue2}");

            double res = ds.GetSumSumSeries(x, StartValue1, StartValue2, StopValue1, StopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Значение двойной суммы = {res}");
        }
    }
}
