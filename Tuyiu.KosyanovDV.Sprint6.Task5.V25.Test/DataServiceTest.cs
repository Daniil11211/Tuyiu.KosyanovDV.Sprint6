using Tuyiu.KosyanovDV.Sprint6.Task5.V25.Lib;

namespace Tuyiu.KosyanovDV.Sprint6.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFileExist()
        {
            string path = @"C:\DataSprint6\InPutDataFileTask5V25.txt";
            
            FileInfo file = new FileInfo(path);
            bool wait = true;
            Assert.AreEqual(true, file.Exists);
        }
    }
}