using Tyuiu.KornevRM.Sprint4.Task0.V15.Lib;
namespace Tyuiu.KornevRM.Sprint4.Task0.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Корнев Р.М. | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Корнев Р.М. | ИСПб-24-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9. Подсчитать сумму четных  *");
            Console.WriteLine("* элементов массива { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 }                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Исходный массив:");
            int[] array = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
            for (int i = 0; i < array.Length; i++) { 
            Console.WriteLine(array[i]+" ");
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");
            int p = Convert.ToInt32(ds.GetMultOddArrEl(array));
            Console.WriteLine(p);
            Console.ReadKey();

        }
    }
}
