using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GalimovAA.Sprint1.Task3.V15.Lib
{
    public class DataService : ISprint1Task3V15
    {
        public double DistanceOverTime(double v1, double v2, double S, double T)
        {
            double traveledDistance = (v1 + v2) * T;

            double newDistance = S - traveledDistance;

            return Math.Round(Math.Max(0, Math.Abs(newDistance)), 3);
        }
    }
}
