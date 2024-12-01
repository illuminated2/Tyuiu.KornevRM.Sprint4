using Tyuiu.KornevRM.Sprint4.Task5.V10.Lib;
namespace Tyuiu.KornevRM.Sprint4.Task5.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Корнев Р.М. | ИСПб-24-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:  Двумерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Корнев Р.М. | ИСПб-24-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от -4 до 7.                         *");
            Console.WriteLine("* Найти сумму положительных элементов.                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, columns];

            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = rnd.Next(-4, 7);
                }
            }



            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }

                Console.WriteLine();
            }

            int res = ds.Calculate(matrix);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма положительных элементов: " + ds.Calculate(matrix));
            Console.ReadKey();
        }
    }
}
