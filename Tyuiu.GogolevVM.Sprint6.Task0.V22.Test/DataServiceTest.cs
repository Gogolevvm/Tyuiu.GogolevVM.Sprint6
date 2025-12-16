using Tyuiu.GogolevVM.Sprint6.Task0.V22.Lib;
namespace Tyuiu.GogolevVM.Sprint6.Task0.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double res = ds.Calculate(2);
            double wait = 11.68;
            Assert.AreEqual(wait, res);
        }
    }
}
