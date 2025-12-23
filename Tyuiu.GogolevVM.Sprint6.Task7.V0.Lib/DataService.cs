namespace Tyuiu.GogolevVM.Sprint6.Task7.V0.Lib
{
    public class DataService
    {
        public int[,] GetMatrix (int[,] matrix)
        {
            int rows = matrix.GetUpperBound (0)+1;
            int columns = matrix.Length / rows;

            int xCol = 2;

            for (int r = 0; r < rows;r++)
            {
                for (int c = xCol; c <= xCol;c++)
                {
                    if (matrix[r,c] == 0)
                    {
                        matrix[r,c] = 1;
                    }
                }
            }
            return matrix;
        }
    }
}
