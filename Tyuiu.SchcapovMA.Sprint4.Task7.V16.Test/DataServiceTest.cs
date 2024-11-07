using Tyuiu.SchcapovMA.Sprint4.Task7.V16.Lib;
namespace Tyuiu.SchcapovMA.Sprint4.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int rows = 5;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            string str = "382976421897948";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 196608;
            Assert.AreEqual(wait, res);

        }
    }
}