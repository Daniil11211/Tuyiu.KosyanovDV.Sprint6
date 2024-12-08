using Tuyiu.KosyanovDV.Sprint6.Task1.V24.Lib;

namespace Tuyiu.KosyanovDV.Sprint6.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExpression()
        {
            DataService ds = new DataService();

            int start = -2;
            int end = 2;

            int len = (end - start) + 1;

            double[] valueResArray;
            valueResArray = new double[len];

            valueResArray[0] = -6.30;
            valueResArray[1] = -5.04;
            valueResArray[2] = -6.00;
            valueResArray[3] = -7.85;
            valueResArray[4] = -2.43;

            double[] res = new double[len];
            res = ds.GetMassFunction(start, end);

            CollectionAssert.AreEqual(valueResArray, res);
        }
    }
}