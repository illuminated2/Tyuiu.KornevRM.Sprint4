using Tyuiu.KornevRM.Sprint4.Task2.V4.Lib;
namespace Tyuiu.KornevRM.Sprint4.Task2.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.Title = "Спринт #4 | Выполнил: Корнев Р.М. | ИСПб-24-1";
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                      *");
            Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                          *");
            Console.WriteLine("* Задание #2                                                                     *");
            Console.WriteLine("* Вариaнт #4                                                                     *");
            Console.WriteLine("* Выполнил: Корнев Р.М. | ИСПб-24-1                                              *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                       *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный случайными     *");
            Console.WriteLine("* в диапазоне от 2 до 9 подсчитать сумму четных элементов массива.               *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] numsArray = new int[len];
            for (int i = 0; i <= len - 1; i++)
            {
                numsArray[i] = rnd.Next(2,9);
            }
            Console.WriteLine("Массив:");
            for (int i = 0; i <= len - 1; i++) { 
            Console.WriteLine(numsArray[i] + " ");
            }
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                      *");
            Console.WriteLine("**********************************************************************************");
            int p = Convert.ToInt32(ds.Calculate(numsArray));
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
