using Tyuiu.EvdokimovKP.Sprint4.Task0.V1.Lib;

namespace Tyuiu.EvdokimovKP.Sprint4.Task0.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArrey = { 6, 4, 3, 2, 1, 0, 9, 8, 7, 5 };
            int res = ds.GetSumEvenArrEl(numsArrey);
            int wait = 20;
            Assert.AreEqual(res, wait);
        }
    }
}
