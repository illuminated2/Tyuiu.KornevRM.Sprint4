using Tyuiu.KornevRM.Sprint4.Task1.V3.Lib;
namespace Tyuiu.KornevRM.Sprint4.Task1.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*ИСКХОДНЫЕ ДАННЫЕ:                                                    *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("Исходный массив:");
            int[] array = { 4, 8, 8, 9, 6, 5, 3, 2, 9, 7, 7, 7 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("***********************************************************************");
            int p = Convert.ToInt32(ds.Calculate(array));
            Console.WriteLine(p);
            Console.ReadKey();

        }
    }
}
