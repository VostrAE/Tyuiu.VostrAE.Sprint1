using Tyuiu.VostrAE.Sprint1.Task1.V16.Lib;
namespace Tyuiu.VostrAE.Sprint1.Task1.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double a = 2;
            double y = 2;
            var res = ds.Calculate(x,a, y);
            Assert.AreEqual(14, res);
        }
    }
}
