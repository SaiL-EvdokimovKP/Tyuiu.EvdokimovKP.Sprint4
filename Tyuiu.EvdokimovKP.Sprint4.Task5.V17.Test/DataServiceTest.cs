using Tyuiu.EvdokimovKP.Sprint4.Task5.V17.Lib;

namespace Tyuiu.EvdokimovKP.Sprint4.Task5.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[,] { { -8, 7, 5, -8, 7 }, { 8, -3, 3, 6, 4 }, { 4, -4, -5, 5, -4 }, { 3, 4, 7, -7, 3 }, { -6, -8, -3, 6, 7 } };
            int res = ds.Calculate(matrix);
            int wait = 10;
            Assert.AreEqual(wait, res);
        }
    }
}
