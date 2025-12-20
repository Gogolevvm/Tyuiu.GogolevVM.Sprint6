using Tyuiu.GogolevVM.Sprint6.Task3.V0.Lib;
namespace Tyuiu.GogolevVM.Sprint6.Task3.V0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[3, 3] { { 0, 1, 2 }, { 3, 0, 5 }, { 3, 4, 5 } };

        private void Form1_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatric_GVM.ColumnCount = columns;
            dataGridViewMatric_GVM.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatric_GVM.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatric_GVM.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxResult_GVM.Text = Convert.ToString(ds.Calculate(mtrx));
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУБ-25-1 Гоголев Всеволод Михайлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
