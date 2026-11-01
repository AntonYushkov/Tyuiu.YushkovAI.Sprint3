using System.Text;
using Tyuiu.YushkovAI.Sprint3.Task2.V22.Lib;

namespace Tyuiu.YushkovAI.Sprint3.Task2.V22
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
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Юшков Антон Игоревич | ПКТб-26-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл do...while, вычислить произведение ряда:                 *");
            Console.WriteLine("* по формуле P = Product(i=1..7) (3 / (i + x^(-i)))^2.                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int Value = 5;
            int StartValue = 1;
            int StopValue = 7;

            Console.WriteLine($"Значение X = {Value}");
            Console.WriteLine($"Старт шага = {StartValue}");
            Console.WriteLine($"Стоп шага = {StopValue}");

            double res = ds.GetMultiplySeries(Value, StartValue, StopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Произведение ряда = {res}");
        }
    }
}
