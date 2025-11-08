using Tyuiu.EvdokimovKP.Sprint4.Task1.V4.Lib;

namespace Tyuiu.EvdokimovKP.Sprint4.Task1.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int res = ds.Calculate(array);
            int wait = 945;
            Assert.AreEqual(wait, res);
        }
    }
}
