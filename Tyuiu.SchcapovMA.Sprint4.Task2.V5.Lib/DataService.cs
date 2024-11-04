﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SchcapovMA.Sprint4.Task2.V5.Lib
{
    public class DataService : ISprint4Task2V5
    {
        public int Calculate(int[] array)
        {
            int MultipArray = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    MultipArray *= array[i];
                }
            }
            return MultipArray;
        }
    }
}
