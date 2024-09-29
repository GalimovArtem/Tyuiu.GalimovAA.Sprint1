using Tyuiu.GalimovAA.Sprint1.Task2.V18.Lib;

namespace Tyuiu.GalimovAA.Sprint1.Task2.V2
{
    class Program
    {

        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Галимов А. А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Галимов Артём Азатович | ПКТб-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Известны длины стороны параллелепипеда.                                 *");
            Console.WriteLine("* Вычислить площадь боковой поверхности параллелепипеда.                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a, b, c;
            Console.WriteLine("Введите значение Первой стороны: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Второй стороны: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Тртьей стороны: ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.CalculateSideSquareParallelepiped(a, b, c));

            Console.ReadKey();


        }
    }
}