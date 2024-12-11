namespace Tuyiu.KosyanovDV.Sprint6.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExistLoad()
        {
            string path = @"C:\DataSprint6\InPutDataFileTask7V21.csv";

            FileInfo file = new FileInfo(path);
            bool wait = true;
            Assert.AreEqual(true, file.Exists);
        }

        [TestMethod]
        public void CheckExistSave()
        {
            string path = @"D:\Microsoft VS\repos\Tuyiu.KosyanovDV.Sprint6\Tuyiu.KosyanovDV.Sprint6.Task7.V21\bin\Debug\net8.0-windows\OutPutFileTask7.csv";

            FileInfo file = new FileInfo(path);
            bool wait = true;
            Assert.AreEqual(true, file.Exists);
        }
    }
}