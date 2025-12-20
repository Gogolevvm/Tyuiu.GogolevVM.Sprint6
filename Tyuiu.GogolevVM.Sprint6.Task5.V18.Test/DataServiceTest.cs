using Tyuiu.GogolevVM.Sprint6.Task5.V18.Lib;
namespace Tyuiu.GogolevVM.Sprint6.Task5.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask5V18.txt";
            var res = ds.LoadFromDataFile(path);
            double[] mass = { -14.32, -7.84, 12.89, -1.57, -3.64, -13.26, -8.91, -17.77, 13.83, 12.76, 8.86, -1.49 };
            CollectionAssert.AreEqual(mass, res);
        }
    
    }
}
