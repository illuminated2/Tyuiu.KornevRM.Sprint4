using Tyuiu.KornevRM.Sprint4.Task3.V18.Lib;
namespace Tyuiu.KornevRM.Sprint4.Task3.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                   *");
            Console.WriteLine("**********************************************************************");

            int[,] array = new int[5, 5] {{ 2, 4, 2, 7, 7 },
                                          { 4, 7, 9, 9, 7 },
                                          { 8, 5, 5, 6, 5 },
                                          { 7, 7, 5, 2, 9 },
                                          { 9, 3, 7, 9, 8 }};

            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            Console.WriteLine("Массив: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                          *");
            Console.WriteLine("**********************************************************************");
            int res = ds.Calculate(array);

            Console.WriteLine("Максимальный элемент в последней строке массива: " + res);
            Console.ReadKey();

        }
    }
}
