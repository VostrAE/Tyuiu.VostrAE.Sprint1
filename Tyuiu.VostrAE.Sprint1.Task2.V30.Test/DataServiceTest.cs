using Tyuiu.VostrAE.Sprint1.Task2.V30.Lib;
namespace Tyuiu.VostrAE.Sprint1.Task2.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ConvertKmToMetre()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertKmToMetre(x);
            Assert.AreEqual(2000, res);
      
        }
    }
}
