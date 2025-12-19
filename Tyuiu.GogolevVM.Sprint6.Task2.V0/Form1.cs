using System.Diagnostics;
using Tyuiu.GogolevVM.SPrint6.Task2.V0.Lib;
namespace Tyuiu.GogolevVM.Sprint6.Task2.V0
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_GVM.Text);
                int stopStep = Convert.ToInt32(textBoxStop_GVM.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chart1.Titles.Add("График функции sin(x)");

                this.chart1.ChartAreas[0].AxisX.Title = "Ось X";
                this.chart1.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chart1.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonResult_GVM.BackColor = Color.Red;
        }

        private void buttonResult_GVM_MouseLeave(object sender, EventArgs e)
        {
            buttonResult_GVM.BackColor = Color.Green;
        }

        private void buttonResult_GVM_MouseDown(object sender, MouseEventArgs e)
        {
            buttonResult_GVM.BackColor = Color.Blue;
        }

        private void buttonHelp_GVM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУБ-25-1 Гоголев Всеволод Михайлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
