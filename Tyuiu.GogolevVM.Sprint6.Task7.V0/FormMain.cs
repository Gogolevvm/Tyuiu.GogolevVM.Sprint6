using Tyuiu.GogolevVM.Sprint6.Task7.V0.Lib;
namespace Tyuiu.GogolevVM.Sprint6.Task7.V0
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_GVM.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        //метод чтения данных из файла

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            // Разделение на строки.
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);


            // Определяем количество строк и столбцов
            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            // Выделите массив данных
            int[,] arrayValues = new int[rows, columns];

            // Заполните массив данными.
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void textBoxCondition_GVM_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialogTask_GVM.ShowDialog();
            openFilePath = openFileDialogTask_GVM.FileName;

            // Выделите массив данных.
            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            // Указываем сетки

            dataGridView1.ColumnCount = columns;
            dataGridView1.RowCount = rows;
            dataGridView2.ColumnCount = columns;
            dataGridView2.RowCount = rows;

            // Задаем ширину столбцов dataGridView1
            for (int i = 0; i < columns; i++)
            {
                dataGridView1.Columns[i].Width = 25;
                dataGridView2.Columns[i].Width = 25;
            }

            // Добавьте данные в dataGridView1 (Заполняем решетки)

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridView1.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
            buttonDone.Enabled = true;



        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            // Выделите массив данных
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(LoadFromFileData((openFilePath)));

            // Добавьте данные в dataGridView2
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridView2.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_GVM.Enabled = true;
        }

        private void buttonSaveFile_GVM_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridView2.RowCount;
            int columns = dataGridView2.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridView2.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridView2.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";

            }


        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 50;
            dataGridView2.ColumnCount = 50;

            dataGridView1.RowCount = 50;
            dataGridView2.RowCount = 50;

            
        }

        private void buttonOpenFile_GVM_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_GVM_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Сохранить файл";
        }

        private void buttonInfo_GVM_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Справка";
        }

        private void buttonInfo_GVM_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
