using Tyuiu.SchcapovMA.Sprint4.Task5.V6.Lib;
namespace Tyuiu.SchcapovMA.Sprint4.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] {{-10, -4, 1, 1, 2 },
                                        { 3, 2, -4, 3, 5 },
                                        { 5, -2, -3, 2, 2 },
                                        { 2, -5, -1, -1, 4 },
                                        { -5, -3, -4, -3, -2 } };
            int[,] res = ds.Calculate(mas2);
            int[,] wait = new int[5, 5]{{-10, -4, 1, 1, 1 },
                                        { 1, 1, -4, 1, 1 },
                                        { 1, -2, -3, 1, 1 },
                                        { 1, -5, -1, -1, 1 },
                                        { -5, -3, -4, -3, -2 } };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}