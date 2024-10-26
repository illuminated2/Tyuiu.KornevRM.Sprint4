using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KornevRM.Sprint4.Task2.V4.Lib
{
    public class DataService : ISprint4Task2V4
    {
        public int Calculate(int[] array)
        {
            int r = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {

                if (array[i] % 2 == 0)
                {
                    continue;
                }
                else
                {
                    r += array[i];
                }
            }
            return r;
        }
    }
}
