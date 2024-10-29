using Tyuiu.KornevRM.Sprint4.Task7.V22.Lib;
namespace Tyuiu.KornevRM.Sprint4.Task7.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: КОРНЕВ Р. М. | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Корнев Руслан Максимович | ИСПб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"695324951753684\".                  *");
            Console.WriteLine("* Преобразуйте ее в матрицу 5 на 3 и подсчитайте произведение четных чисел*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int n = 5;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string value = "695324951753684";

            

            Console.WriteLine("Массив");
            int[,] matrix = new int[n, m];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[count].ToString());
                    count++;
                    Console.Write(matrix[i, j] + ", ");
                }
                Console.WriteLine();
            }


                Console.WriteLine();
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Результат:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("произведение четных чисел : " + ds.Calculate(n,m, value));
            Console.ReadKey();


        }
    }
}
