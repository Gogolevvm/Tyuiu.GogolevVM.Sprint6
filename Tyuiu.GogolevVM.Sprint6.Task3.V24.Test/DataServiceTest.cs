using Tyuiu.GogolevVM.Sprint6.Task3.V24.Lib;
namespace Tyuiu.GogolevVM.Sprint6.Task3.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mtrx = new int[5, 5] { { -17, -6, 10, 5, 3 }, 
                { -10, -14, 10, -7, -3 }, { -19, 9, 8, -17, -9 }, { -19, -5, -9, -18, 14 }, { 17, 12, 11, 12, 2 } };

            var res = ds.Calculate(mtrx);
            int[,] wait = new int[5, 5] { { -17, -6, 10, 5, 3 }, { 0, 0, 0, -7, -3 }, { -19, 9, 8, -17, -9 }, { -19, -5, -9, -18, 14 }, { 17, 12, 11, 12, 2 } };

            CollectionAssert.AreEqual(wait,res);

        }
    }
}
