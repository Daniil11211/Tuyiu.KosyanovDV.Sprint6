using Tuyiu.KosyanovDV.Sprint6.Task0.V17.Lib;

namespace Tuyiu.KosyanovDV.Sprint6.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            DataService ds = new DataService();
            double y = ds.Calculate(3);
            Assert.AreEqual(6.695, y);
        }
    }
}