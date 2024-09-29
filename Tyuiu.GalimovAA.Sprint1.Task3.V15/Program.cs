using Tyuiu.GalimovAA.Sprint1.Task3.V15.Lib;

namespace Tyuiu.GalimovAA.Sprint1.Task3.V15
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
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

            double v1, v2, S, T;
            Console.WriteLine("Введите значение скорости первого автомобиля: ");
            v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение скорости второго автомобиля: ");
            v2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение расстояния на котором находятся автомобили друг от друга: ");
            S = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение времени через которое нужно узнать новое расстояние между автомобилями: ");
            T = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.DistanceOverTime(v1, v2, S, T));

            Console.ReadKey();


        }
    }
}