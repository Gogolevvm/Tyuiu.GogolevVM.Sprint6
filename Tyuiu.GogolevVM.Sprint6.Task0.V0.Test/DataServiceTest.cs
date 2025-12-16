using Tyuiu.GogolevVM.Sprint6.Task0.V0.Lib;
namespace Tyuiu.GogolevVM.Sprint6.Task0.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(7, 8, 9);
            double wait = 1.667;
            Assert.AreEqual(wait,res);
        }
    }
}
