using Tyuiu.GalimovAA.Sprint1.Task7.V4.Lib;

namespace Tyuiu.GalimovAA.Sprint1.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x, y; x = 1; y = 2;
            double res = ds.Calculate (x, y);
            Assert.AreEqual (-0.511, res);
        }
    }
}