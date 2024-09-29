using Tyuiu.GalimovAA.Sprint1.Task3.V15.Lib;

namespace Tyuiu.GalimovAA.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double v1, v2, S, T; v1 = 80; v2 = 100; S = 200; T = 1;
            var res = ds.DistanceOverTime(v1, v2, S, T);
            Assert.AreEqual(20, res);
        }
    }
}