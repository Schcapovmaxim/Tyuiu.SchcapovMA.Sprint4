using Tyuiu.SchcapovMA.Sprint4.Task6.V27.Lib;
namespace Tyuiu.SchcapovMA.Sprint4.Task6.V27
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
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Щапов Максим Александрович | ИБКСб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Квадрат\", \"Прямоугольник\", \"Круг\",  *");
            Console.WriteLine("* \"Треугольник\",\"Пятиугольник\", \"Шестиугольник\", \"Восьмиугольник\"]*");
            Console.WriteLine("* используя класс Array подсчитайте кол-во элементов, длина которых < 7   *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            var week= new string[] { "Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник", "Восьмиугольник" };
            



            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < week.Length-1; i++)
            {
             Console.Write(week[i]);
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество элементов длина которых меньше 7 = " + ds.Calculate(week));
            Console.ReadKey();
        }
    }
}
