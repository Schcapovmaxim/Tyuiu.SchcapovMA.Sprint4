using Tyuiu.SchcapovMA.Sprint4.Task6.V27.Lib;
namespace Tyuiu.SchcapovMA.Sprint4.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var figure = new string[] { "�������", "�������������", "����", "�����������", "������������", "�������������", "��������������" };
            int res = ds.Calculate(figure);
            int wait = 1;
            Assert.AreEqual(res, wait);

        }
    }
}