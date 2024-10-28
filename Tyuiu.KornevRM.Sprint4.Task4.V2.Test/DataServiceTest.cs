using Tyuiu.KornevRM.Sprint4.Task4.V2.Lib;
namespace Tyuiu.KornevRM.Sprint4.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] { { 2, 2, 5, 5, 9 },
                                          { 7, 3, 8, 8, 9 },
                                          { 6, 7, 9, 3, 5 },
                                          { 7, 5, 7, 7, 8 },
                                          { 2, 2, 4, 7, 9 } };
            int[,] res = ds.Calculate(matrix);
            int wait = 9;
            Assert.AreEqual(res, wait);

        }
    }
}