using Tyuiu.KornevRM.Sprint4.Task6.V29.Lib;
namespace Tyuiu.KornevRM.Sprint4.Task6.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                   *");
            Console.WriteLine("**********************************************************************");
            String[] array = { "Весна", "Лето", "Осень", "Зима" };
            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                          *");
            Console.WriteLine("**********************************************************************");

            int count = ds.Calculate(array);
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
