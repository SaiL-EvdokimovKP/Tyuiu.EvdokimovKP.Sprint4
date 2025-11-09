using Tyuiu.EvdokimovKP.Sprint4.Task6.V25.Lib;

namespace Tyuiu.EvdokimovKP.Sprint4.Task6.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var x = new string[] { "Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей" };
            int res = ds.Calculate(x); 
            int wait = 2;
            Assert.AreEqual(res, wait);
        }
    }
}
