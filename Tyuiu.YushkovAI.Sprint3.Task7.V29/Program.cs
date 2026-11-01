using System.Text;
using Tyuiu.YushkovAI.Sprint3.Task7.V29.Lib;

namespace Tyuiu.YushkovAI.Sprint3.Task7.V29
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
            Console.WriteLine("* Тема: Создание итогового решения по спринту                               *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Юшков Антон Игоревич | ПКТб-26-1                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Табулировать F(x) = (2*x-3)/(cos(x)-2*x) + 5*x - 6 на [-5; 5].            *");
            Console.WriteLine("* Шаг равен 1. При нулевом знаменателе вернуть значение 0.                  *");
            Console.WriteLine("* Значения округлить до двух знаков и занести в массив.                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int StartValue = -5;
            int StopValue = 5;
            Console.WriteLine($"Начало отрезка = {StartValue}");
            Console.WriteLine($"Конец отрезка = {StopValue}");
            Console.WriteLine("Шаг = 1");

            double[] res = ds.GetMassFunction(StartValue, StopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("+-------+------------+");
            Console.WriteLine("|   x   |    F(x)    |");
            Console.WriteLine("+-------+------------+");

            for (int i = 0; i < res.Length; i++)
            {
                int x = StartValue + i;
                Console.WriteLine("| {0,5} | {1,10:F2} |", x, res[i]);
            }

            Console.WriteLine("+-------+------------+");
        }
    }
}
