using Tyuiu.GalimovAA.Sprint1.Task4.V3.Lib;

namespace Tyuiu.GalimovAA.Sprint1.Task4.V3
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
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #3                                                            *");
            Console.WriteLine("* Выполнил: Галимов Артём Азатович | ПКТб-24-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, решающую следующую задачу:                          *");
            Console.WriteLine("* два автомобиля имеют скорости V1 км/ч и V2 км/ч соответственно,         *");
            Console.WriteLine("* находятся на расстоянии S км друг от друга                              *");
            Console.WriteLine("* и движутся в противоположные стороны.                                   *");
            Console.WriteLine("* Определить расстояние между ними через T часов.                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, y;
            Console.WriteLine("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadKey();


        }
    }
}