using System.Runtime.Intrinsics.X86;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SchcapovMA.Sprint4.Task0.V5.Lib
{
    public class DataService : ISprint4Task0V5
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int cnt = 0;
            for (int i = 0; i <= array.Length - 1; i++) 
            {
                if (array[i] % 2 == 0) { cnt += array[i]; }
            }
            return cnt;
        }
    }
}
