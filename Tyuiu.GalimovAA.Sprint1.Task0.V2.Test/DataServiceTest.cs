using Tyuiu.GalimovAA.Sprint1.Task0.V2.Lib;

namespace Tyuiu.GalimovAA.Sprint1.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(1, res);
        }
    }
}