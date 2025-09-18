using Tyuiu.VostrAE.Sprint1.Task3.V2.Lib;
namespace Tyuiu.VostrAE.Sprint1.Task3.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void PurchaseAmount()
        {
            DataService ds = new DataService ();
            double priceNotebook = 20;
            int amountNotebook = 2;
            double pricePencil = 5;
            int amountPencil = 3;
            double wait = 45;
            var res = ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil);
            Assert.AreEqual(wait, res);
        }
    }
}

