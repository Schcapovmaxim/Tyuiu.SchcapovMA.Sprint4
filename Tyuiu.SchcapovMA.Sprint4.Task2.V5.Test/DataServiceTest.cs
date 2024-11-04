using Tyuiu.SchcapovMA.Sprint4.Task2.V5.Lib;
namespace Tyuiu.SchcapovMA.Sprint4.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] numsArray = { 3, 6, 5, 5, 5, 6, 5, 5, 5, 5, 3, 6, 6, 6 };
            int res = ds.Calculate(numsArray);
            int wait = 7776;
            Assert.AreEqual(res, wait);
        }
    }
}