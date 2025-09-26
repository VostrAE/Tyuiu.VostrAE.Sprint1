using Tyuiu.VostrAE.Sprint1.Task6.V10.Lib;
namespace Tyuiu.VostrAE.Sprint1.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string StrTest = "клубень!";
            DataService ds = new DataService();
            string res = ds.DeleteMiddleLetter(StrTest);
            string wait = "клуень";
            Assert.AreEqual(wait, res);
        }
    }
}
