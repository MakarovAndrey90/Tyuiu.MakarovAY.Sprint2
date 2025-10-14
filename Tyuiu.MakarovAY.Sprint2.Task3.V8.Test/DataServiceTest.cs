using System.Security.Cryptography.X509Certificates;
using Tyuiu.MakarovAY.Sprint2.Task3.V8.Lib;
namespace Tyuiu.MakarovAY.Sprint2.Task3.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc1()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = -4.588;
            Assert.AreEqual(wait, ds.Calculate(x));
        }

        [TestMethod]
        public void ValidCalc2()
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = 0.75;
            Assert.AreEqual(wait, ds.Calculate(x));
        }

        [TestMethod]
        public void ValidCalc3()
        {
            DataService ds = new DataService();
            double x = -1;
            double wait = 0.25;
            Assert.AreEqual(wait, ds.Calculate(x));
        }

        [TestMethod]
        public void ValidCalc4()
        {
            DataService ds = new DataService();
            double x = -13;
            double wait = -142.615;
            Assert.AreEqual(wait, ds.Calculate(x));
        }
    }
}