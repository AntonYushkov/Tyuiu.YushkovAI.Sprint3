using System.Text;
using Tyuiu.YushkovAI.Sprint3.Task6.V30.Lib;

namespace Tyuiu.YushkovAI.Sprint3.Task6.V30
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
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Юшков Антон Игоревич | ПКТб-26-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Среди целых чисел отрезка [11; 17] найти количество всех делителей.     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int StartValue = 11;
            int StopValue = 17;
            Console.WriteLine($"Начало отрезка = {StartValue}");
            Console.WriteLine($"Конец отрезка = {StopValue}");

            int res = ds.GetSumTheDivisors(StartValue, StopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Количество всех делителей = {res}");
        }
    }
}
