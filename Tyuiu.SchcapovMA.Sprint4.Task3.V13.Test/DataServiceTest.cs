using Tyuiu.SchcapovMA.Sprint4.Task3.V13.Lib;
namespace Tyuiu.SchcapovMA.Sprint4.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5,3]  {{1,2,3 },
                                        { 1,4,5 },
                                        { 2,4,7 },
                                        { 6,8,2 },
                                        { 1,12,3 } };
            int res = ds.Calculate(mas2);
            int wait = 20;
            Assert.AreEqual(res, wait);
        }
    }
}