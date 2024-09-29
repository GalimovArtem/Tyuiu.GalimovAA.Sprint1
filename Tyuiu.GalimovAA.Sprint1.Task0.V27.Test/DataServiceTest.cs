using Tyuiu.GalimovAA.Sprint1.Task0.V27.Lib;

namespace Tyuiu.GalimovAA.Sprint1.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.5, res);
        }
    }
}