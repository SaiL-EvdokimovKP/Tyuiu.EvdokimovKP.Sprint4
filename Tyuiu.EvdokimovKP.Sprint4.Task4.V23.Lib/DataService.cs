using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.EvdokimovKP.Sprint4.Task4.V23.Lib
{
    public class DataService : ISprint4Task4V23
    {
        public int Calculate(int[,] matrix)
        {
            int x = 0;
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        x += matrix[i, j];
                    }
                }
            }
            return x;
        }
    }
}
