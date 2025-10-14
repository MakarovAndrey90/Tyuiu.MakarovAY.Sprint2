using Tyuiu.MakarovAY.Sprint2.Task4.V2.Lib;
namespace Tyuiu.MakarovAY.Sprint2.Task4.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 10; double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 12.2;
            Assert.AreEqual(wait, res);
            
        }

        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 8;
            double res = ds.Calculate(x, y);
            double wait = 1.3;
            Assert.AreEqual(wait, res);
        }
    }
}
