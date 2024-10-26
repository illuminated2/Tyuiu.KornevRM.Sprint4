using Tyuiu.KornevRM.Sprint4.Task2.V4.Lib;
namespace Tyuiu.KornevRM.Sprint4.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 4, 0, 3, 2,7,8,9,2,2,2,2,2,2 };
            int res = ds.Calculate(array);
            int wait = 0;
            Assert.AreEqual(wait, res);
        }
    }
}