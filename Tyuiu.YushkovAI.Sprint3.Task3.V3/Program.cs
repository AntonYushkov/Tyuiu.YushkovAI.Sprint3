using System.Text;
using Tyuiu.YushkovAI.Sprint3.Task3.V3.Lib;

namespace Tyuiu.YushkovAI.Sprint3.Task3.V3
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
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Юшков Антон Ильич | ПКТб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя foreach, подсчитать минимальное количество букв f,            *");
            Console.WriteLine("* находящихся на соседних позициях в строке:                              *");
            Console.WriteLine("* cvbmzff orffgtrr dkfvfffdr                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "cvbmzff orffgtrr dkfvfffdr";
            char item = 'f';

            Console.WriteLine($"Строка = {value}");
            Console.WriteLine($"Символ = {item}");

            int res = ds.GetMinCharCount(value, item);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Минимальное количество соседних букв f = {res}");
        }
    }
}
