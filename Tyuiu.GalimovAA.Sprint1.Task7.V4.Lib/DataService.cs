using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GalimovAA.Sprint1.Task7.V4.Lib
{
    public class DataService : ISprint1Task7V4
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Log(Math.Abs((y - Math.Sqrt(Math.Abs(x))) * (x - (y / (x + (Math.Pow(x, 2) / 4))))));
            return Math.Round(res, 3);
        }
    }
}
