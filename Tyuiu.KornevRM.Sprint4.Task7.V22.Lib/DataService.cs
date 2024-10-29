using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KornevRM.Sprint4.Task7.V22.Lib
{
    public class DataService : ISprint4Task7V22
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mtrx = new int[n, m];
            int p = 1;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = int.Parse(value[count].ToString());
                    if(mtrx[i, j]%2== 0)
                    {
                        p *= mtrx[i, j];
                    }
                }
            }
            return p;
        }
    }
}
