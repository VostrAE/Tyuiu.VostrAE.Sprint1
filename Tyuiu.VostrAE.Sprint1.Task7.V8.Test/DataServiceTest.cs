using Tyuiu.VostrAE.Sprint1.Task7.V8.Lib;
namespace Tyuiu.VostrAE.Sprint1.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 3;
            double wait = 1.788;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(wait,res);
        }
    }
}
