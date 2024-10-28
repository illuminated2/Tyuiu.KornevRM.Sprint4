using Tyuiu.KornevRM.Sprint4.Task5.V10.Lib;
namespace Tyuiu.KornevRM.Sprint4.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas2 = { { -4, 4, 2, 0, 5 },
                            { -1, 6, 2, 3, 5 },
                            { 3, 4, 2, 4, -5 },
                            { 7, -2, 2, 1, -3 },
                            { -3, 6, 0, 5, -2 } };
            int res = ds.Calculate(mas2);
            int wait = 61;

            Assert.AreEqual(wait, res);
        }
    }
}