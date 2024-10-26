using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KornevRM.Sprint4.Task1.V3.Lib
{
    public class DataService : ISprint4Task1V3
    {
        public int Calculate(int[] array)
        {
            int r = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if(i >= 2 && i <= 9)
                {
                    if(array[i] % 2 == 0)
                    {
                        r *= array[i];
                    }
                }
            }
            return r;

        }
    }
}
