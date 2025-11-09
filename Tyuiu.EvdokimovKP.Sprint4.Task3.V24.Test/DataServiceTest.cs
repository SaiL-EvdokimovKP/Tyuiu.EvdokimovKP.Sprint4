using Tyuiu.EvdokimovKP.Sprint4.Task3.V24.Lib;

namespace Tyuiu.EvdokimovKP.Sprint4.Task3.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] masiv = new int[,] { { 3, 6, 1, 7, 3 },
                                        { 2, 3, 7, 1, 1 },
                                        { 1, 2, 5, 5, 1 },
                                        { 7, 6, 7, 6, 2 },
                                        { 7, 6, 4, 5, 8 } };
            int res = ds.Calculate(masiv);
            int wait = 2;
            Assert.AreEqual(res, wait);
        }
    }
}
