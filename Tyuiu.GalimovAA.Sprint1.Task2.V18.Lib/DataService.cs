using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GalimovAA.Sprint1.Task2.V18.Lib
{
    public class DataService : ISprint1Task2V18
    {
        public int CalculateSideSquareParallelepiped(int a, int b, int c)
        {
            return 2 * c * (a + b);
        }
    }
}
