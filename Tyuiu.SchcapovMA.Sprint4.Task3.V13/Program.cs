using Tyuiu.SchcapovMA.Sprint4.Task3.V13.Lib;
namespace Tyuiu.SchcapovMA.Sprint4.Task3.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Щапов М.А. | ИБКСб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы.(статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Щапов Максим Александрович | ИБКСб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 7. Найдите сумму элементов  *");
            Console.WriteLine("* в третьем столбце массива.                                              *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            int[,] mtrx = new int[5, 5] {{ 4, 7, 4, 2, 1},
                                         { 6, 7, 3, 6, 5},
                                         { 6, 5, 3, 3, 5},
                                         { 4, 4, 6, 4, 7},
                                         { 2, 1, 2, 3, 4}};
            int rows = mtrx.GetUpperBound(0) + 1;
            int colums = mtrx.Length / rows;

            

            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                       
                 Console.Write($"{mtrx[i, j]}\t");
                    
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Суммма элементов в третьем стобце массива равно = " + ds.Calculate(mtrx));
            Console.ReadKey();
        }
    }
}
