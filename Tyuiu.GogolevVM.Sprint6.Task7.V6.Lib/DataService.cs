using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GogolevVM.Sprint6.Task7.V6.Lib
{
    public class DataService : ISprint6Task7V6
    {
        public int[,] GetMatrix(string path)
        {
            string content = File.ReadAllText(path);
            string[] rows = content.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            int row = rows.Length;
            int column = rows[0].Split(';').Length;
            int[,] matrix = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                string[] values = rows[i].Split(';');

                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = Convert.ToInt32(values[j].Trim());
                }
            }
            for (int j = 0; j < column; j++)
            {
                if (matrix[6, j] != 6)
                {
                    matrix[6, j] = 0;
                }
            }
            return matrix;
        }
    }
}
