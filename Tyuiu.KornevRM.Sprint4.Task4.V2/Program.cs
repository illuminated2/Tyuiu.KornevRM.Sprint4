using Tyuiu.KornevRM.Sprint4.Task4.V2.Lib;
namespace Tyuiu.KornevRM.Sprint4.Task4.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            

            Console.Title = "Спринт #4 | Выполнил: Корнев Р.М. | ИСПб-24-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Двумерные массивы. (ввод с клавиатуры)                                  *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #2                                                             *");
            Console.WriteLine("* Выполнил: Корнев Р.М. | ИСПб-24-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 9. Заменить нечетные        *");
            Console.WriteLine("* элементы массива на 0.                                                  *");
            Console.WriteLine("* 2, 2, 5, 5, 9,                                                          *");
            Console.WriteLine("* 7, 3, 8, 8, 9,                                                          *");
            Console.WriteLine("* 6, 7, 9, 3, 5,                                                          *");
            Console.WriteLine("* 7, 5, 7, 7, 8,                                                          *");
            Console.WriteLine("* 2, 2, 4, 7, 9,                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] matrix = new int[5, 5] { { 2, 2, 5, 5, 9 },
                                          { 7, 3, 8, 8, 9 },
                                          { 6, 7, 9, 3, 5 },
                                          { 7, 5, 7, 7, 8 },
                                          { 2, 2, 4, 7, 9 } };
            Console.WriteLine("Массив: ");
            for (int i = 0;  i < matrix.GetLength(0); i++)
            {
                for(int j = 0;  j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            
            }
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                          *");
            Console.WriteLine("**********************************************************************");

            int[,] ready = ds.Calculate(matrix);
            for (int i = 0; i < ready.GetLength(0); i++)
            {
                for (int j = 0; j < ready.GetLength(1); j++)
                {
                    Console.Write($"{ready[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            }
    }
}
