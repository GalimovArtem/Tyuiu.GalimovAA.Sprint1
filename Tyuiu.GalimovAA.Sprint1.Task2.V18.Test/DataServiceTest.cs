using Tyuiu.GalimovAA.Sprint1.Task2.V18.Lib;

namespace Tyuiu.GalimovAA.Sprint1.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a, b, c; a= 1; b = 2; c = 3;
            var res = ds.CalculateSideSquareParallelepiped(a, b, c);
            Assert.AreEqual(18, res);
        }
    }
}