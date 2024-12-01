using Tyuiu.KornevRM.Sprint4.Task6.V29.Lib;
namespace Tyuiu.KornevRM.Sprint4.Task6.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Корнев Р.М. | ИСПб-24-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:  Двумерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Корнев Р.М. | ИСПб-24-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [Весна, Лето, Осень, Зима] используя        *");
            Console.WriteLine("* класс Array подсчитайте количество элементов, длина которых больше 4.   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            String[] array = { "Весна", "Лето", "Осень", "Зима" };
            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            int count = ds.Calculate(array);
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
