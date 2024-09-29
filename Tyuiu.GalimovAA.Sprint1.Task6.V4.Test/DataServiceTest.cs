using Tyuiu.GalimovAA.Sprint1.Task6.V4.Lib;

namespace Tyuiu.GalimovAA.Sprint1.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "весело сыгранно спето надето выбрано удвоенно раздавленно";
            DataService ds = new DataService();
            string res = ds.CheckDoubleN(input);
            string wait = "сыгранно удвоенно раздавленно";
            Assert.AreEqual(wait, res);
        }
    }
}