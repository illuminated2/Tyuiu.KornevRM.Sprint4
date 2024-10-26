using Tyuiu.KornevRM.Sprint4.Task2.V4.Lib;
namespace Tyuiu.KornevRM.Sprint4.Task2.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*ИСКХОДНЫЕ ДАННЫЕ:                                                    *");
            Console.WriteLine("***********************************************************************");
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
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("***********************************************************************");
            int p = Convert.ToInt32(ds.Calculate(numsArray));
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
