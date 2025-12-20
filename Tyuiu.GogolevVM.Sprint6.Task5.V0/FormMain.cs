using Tyuiu.GogolevVM.Sprint6.Task5.V0.Lib;
namespace Tyuiu.GogolevVM.Sprint6.Task5.V0
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\Home\source\repos\Tyuiu.GogolevVM.Sprint6\Tyuiu.GogolevVM.Sprint6.Task5.V0\bin\Debug\OutPutFIleTask5.txt";
        private void buttonDone_GVM_Click(object sender, EventArgs e)
        {
            dataGridViewResult_GVM.ColumnCount = 2;
            dataGridViewResult_GVM.Columns[0].Width = 20;
            dataGridViewResult_GVM.Columns[1].Width = 50;

            this.chartDiag_GVM.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_GVM.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_GVM.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_GVM.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_GVM.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonFile_GVM_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУБ-25-1 Гоголев Всеволод Михайлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
