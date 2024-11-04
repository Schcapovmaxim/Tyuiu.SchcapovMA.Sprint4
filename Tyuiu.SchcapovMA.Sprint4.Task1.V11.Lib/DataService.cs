using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SchcapovMA.Sprint4.Task1.V11.Lib
{
    public class DataService : ISprint4Task1V11
    {
        public int Calculate(int[] array)
        {
            int SumArray = 0;
            for (int i=0; i < array.Length; i++)
            {
                SumArray += array[i] * (array[i] % 2 == 0 ? 1 : 0);
            }
            return SumArray;
        }
    }
}
