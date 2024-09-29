using Tyuiu.GalimovAA.Sprint1.Task4.V3.Lib;

namespace Tyuiu.GalimovAA.Sprint1.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x, y; x = 3; y = 4;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(3, res);
        }
    }
}