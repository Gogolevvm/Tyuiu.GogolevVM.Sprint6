using Tyuiu.GogolevVM.Sprint6.Task0.V22.Lib;
namespace Tyuiu.GogolevVM.Sprint6.Task0.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonDone_GVM_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarA.Text)));

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBoxVarA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы АСОиУБ-25-1 Гоголев Всеволод Михайлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
