using Tyuiu.GalimovAA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.GalimovAA.Sprint1.Task5.V1
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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Галимов Артём Азатович | ПКТб-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).   *");
            Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x1, y1, x2, y2;
            Console.WriteLine("Введите значение X1: ");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение X2: ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.DistanceBetweenDots(x1, y1, x2, y2));

            Console.ReadKey();


        }
    }
}