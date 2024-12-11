namespace Tuyiu.KosyanovDV.Sprint6.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckExist()
        {
            string path = @"C:\DataSprint6\InPutDataFileTask6V11.txt";

            FileInfo file = new FileInfo(path);
            bool wait = true;
            Assert.AreEqual(true, file.Exists);
        }
    }
}