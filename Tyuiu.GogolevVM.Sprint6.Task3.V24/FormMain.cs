using Tyuiu.GogolevVM.Sprint6.Task3.V24.Lib;
namespace Tyuiu.GogolevVM.Sprint6.Task3.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { -17, -6, 10, 5, 3 },
                { -10, -14, 10, -7, -3 }, { -19, 9, 8, -17, -9 }, { -19, -5, -9, -18, 14 }, { 17, 12, 11, 12, 2 } };

        private void FormMain_Load(object sender, EventArgs e)
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
