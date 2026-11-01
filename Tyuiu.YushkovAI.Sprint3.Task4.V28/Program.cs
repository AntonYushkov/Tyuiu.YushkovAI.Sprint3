using System.Text;
using Tyuiu.YushkovAI.Sprint3.Task4.V28.Lib;

namespace Tyuiu.YushkovAI.Sprint3.Task4.V28
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
            Console.WriteLine("* Тема: Использование continue и break в циклах                            *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Юшков Антон Игоревич | ПКТб-26-1                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке [-5; 5] вычислить y = (cos(x) + sin(x)) / x.                   *");
            Console.WriteLine("* При x = 0 пропустить значение. Полученные значения суммировать.          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int StartValue = -5;
            int StopValue = 5;
            Console.WriteLine($"Начало отрезка = {StartValue}");
            Console.WriteLine($"Конец отрезка = {StopValue}");

            double res = ds.Calculate(StartValue, StopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Сумма значений функции = {res}");
        }
    }
}
