using Tuyiu.KosyanovDV.Sprint6.Task2.V14.Lib;

namespace Tuyiu.KosyanovDV.Sprint6.Task2.V14.Test
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

            valueResArray[0] = 10.98;
            valueResArray[1] = 7.94;
            valueResArray[2] = 3.00;
            valueResArray[3] = 3.23;
            valueResArray[4] = -0.45;

            double[] res = new double[len];
            res = ds.GetMassFunction(start, end);

            CollectionAssert.AreEqual(valueResArray, res);
        }
    }
}