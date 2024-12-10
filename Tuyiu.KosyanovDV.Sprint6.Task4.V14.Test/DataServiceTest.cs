using Tuyiu.KosyanovDV.Sprint6.Task4.V14.Lib;

namespace Tuyiu.KosyanovDV.Sprint6.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExpression()
        {
            DataService ds = new DataService();

            double[] res = ds.GetMassFunction(-1, 1);

            double[] wait = new double[3];

            wait [0] = -24.92;
            wait[1] = -5.00;
            wait[2] = -1.46;

            CollectionAssert.AreEqual(res, wait);
        }
    }
}