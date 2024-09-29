using Tyuiu.GalimovAA.Sprint1.Task5.V1.Lib;

namespace Tyuiu.GalimovAA.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x1, y1, x2, y2; x1 = 2; y1 = 2; x2 = 4; y2 = 4;
            double res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Assert.AreEqual(2, res);
        }
    }
}