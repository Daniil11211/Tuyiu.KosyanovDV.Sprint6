using Tuyiu.KosyanovDV.Sprint6.Task3.V15.Lib;

namespace Tuyiu.KosyanovDV.Sprint6.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckMatrix()
        {
            DataService ds = new DataService();
            int[,] matrix = { { 1, 2, 8 },
                              { -2, 3, -1 },
                              { 7, 8, 9 } };

            matrix = ds.Calculate(matrix);

            int[,] resMatrix = { { 1, 2, -1 },
                              { -2, 3, 8 },
                              { 7, 8, 9 } };

            CollectionAssert.AreEqual(resMatrix, matrix);
        }
    }
}