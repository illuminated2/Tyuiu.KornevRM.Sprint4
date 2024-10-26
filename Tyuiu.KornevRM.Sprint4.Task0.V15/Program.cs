using Tyuiu.KornevRM.Sprint4.Task0.V15.Lib;
namespace Tyuiu.KornevRM.Sprint4.Task0.V15
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
            int[] array = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
            for (int i = 0; i < array.Length; i++) { 
            Console.WriteLine(array[i]+" ");
            }
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("***********************************************************************");
            int p = Convert.ToInt32(ds.GetMultOddArrEl(array));
            Console.WriteLine(p);
            Console.ReadKey();

        }
    }
}
