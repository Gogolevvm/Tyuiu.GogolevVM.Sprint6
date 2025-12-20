using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GogolevVM.Sprint6.Task3.V0.Lib
{
    public class DataService : ISprint6Task3V0
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int count = 0;

            for (int i = 0; i  < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
