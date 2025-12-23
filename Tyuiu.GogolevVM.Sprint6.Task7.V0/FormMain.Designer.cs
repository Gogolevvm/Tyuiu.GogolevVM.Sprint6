namespace Tyuiu.GogolevVM.Sprint6.Task7.V0
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonDone = new Button();
            buttonOpenFile_GVM = new Button();
            buttonSaveFile_GVM = new Button();
            buttonInfo_GVM = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            textBoxCondition_GVM = new TextBox();
            groupBoxCondition_GVM = new GroupBox();
            openFileDialogTask_GVM = new OpenFileDialog();
            toolTipButton = new ToolTip(components);
            saveFileDialogMatrix = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBoxCondition_GVM.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.BackgroundImage = Properties.Resources.page_go;
            buttonDone.BackgroundImageLayout = ImageLayout.Center;
            buttonDone.Enabled = false;
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Location = new Point(128, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(102, 60);
            buttonDone.TabIndex = 0;
            toolTipButton.SetToolTip(buttonDone, "Выполнить обработку данных");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            // 
            // buttonOpenFile_GVM
            // 
            buttonOpenFile_GVM.BackgroundImage = Properties.Resources.folder_page_white;
            buttonOpenFile_GVM.BackgroundImageLayout = ImageLayout.Center;
            buttonOpenFile_GVM.Location = new Point(11, 12);
            buttonOpenFile_GVM.Name = "buttonOpenFile_GVM";
            buttonOpenFile_GVM.Size = new Size(110, 60);
            buttonOpenFile_GVM.TabIndex = 1;
            toolTipButton.SetToolTip(buttonOpenFile_GVM, "Открыть файл для обработки данных в формате CSV\r\n\r\n\r\n");
            buttonOpenFile_GVM.UseVisualStyleBackColor = true;
            buttonOpenFile_GVM.Click += button2_Click;
            buttonOpenFile_GVM.MouseEnter += buttonOpenFile_GVM_MouseEnter;
            // 
            // buttonSaveFile_GVM
            // 
            buttonSaveFile_GVM.BackgroundImage = Properties.Resources.script_save;
            buttonSaveFile_GVM.BackgroundImageLayout = ImageLayout.Center;
            buttonSaveFile_GVM.Enabled = false;
            buttonSaveFile_GVM.FlatStyle = FlatStyle.Flat;
            buttonSaveFile_GVM.Location = new Point(236, 12);
            buttonSaveFile_GVM.Name = "buttonSaveFile_GVM";
            buttonSaveFile_GVM.Size = new Size(94, 60);
            buttonSaveFile_GVM.TabIndex = 2;
            toolTipButton.SetToolTip(buttonSaveFile_GVM, "Сохранить обработанные данные в файл в формате CSV");
            buttonSaveFile_GVM.UseVisualStyleBackColor = true;
            buttonSaveFile_GVM.Click += buttonSaveFile_GVM_Click;
            buttonSaveFile_GVM.MouseEnter += buttonSaveFile_GVM_MouseEnter;
            // 
            // buttonInfo_GVM
            // 
            buttonInfo_GVM.BackgroundImage = Properties.Resources.information;
            buttonInfo_GVM.BackgroundImageLayout = ImageLayout.Center;
            buttonInfo_GVM.Location = new Point(857, 12);
            buttonInfo_GVM.Name = "buttonInfo_GVM";
            buttonInfo_GVM.Size = new Size(94, 60);
            buttonInfo_GVM.TabIndex = 3;
            toolTipButton.SetToolTip(buttonInfo_GVM, "Сведение о программе");
            buttonInfo_GVM.UseVisualStyleBackColor = true;
            buttonInfo_GVM.Click += buttonInfo_GVM_Click;
            buttonInfo_GVM.MouseEnter += buttonInfo_GVM_MouseEnter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 200);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(110, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "Ввод";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(460, 209);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            textBox2.Text = "Вывод";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Location = new Point(12, 233);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(423, 317);
            dataGridView1.TabIndex = 6;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(460, 233);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(410, 317);
            dataGridView2.TabIndex = 1;
            // 
            // textBoxCondition_GVM
            // 
            textBoxCondition_GVM.Location = new Point(0, 26);
            textBoxCondition_GVM.Multiline = true;
            textBoxCondition_GVM.Name = "textBoxCondition_GVM";
            textBoxCondition_GVM.ReadOnly = true;
            textBoxCondition_GVM.Size = new Size(939, 132);
            textBoxCondition_GVM.TabIndex = 0;
            textBoxCondition_GVM.Text = resources.GetString("textBoxCondition_GVM.Text");
            textBoxCondition_GVM.TextChanged += textBoxCondition_GVM_TextChanged;
            // 
            // groupBoxCondition_GVM
            // 
            groupBoxCondition_GVM.Controls.Add(textBoxCondition_GVM);
            groupBoxCondition_GVM.Location = new Point(12, 78);
            groupBoxCondition_GVM.Name = "groupBoxCondition_GVM";
            groupBoxCondition_GVM.Size = new Size(858, 158);
            groupBoxCondition_GVM.TabIndex = 4;
            groupBoxCondition_GVM.TabStop = false;
            groupBoxCondition_GVM.Text = "Условие";
            // 
            // openFileDialogTask_GVM
            // 
            openFileDialogTask_GVM.FileName = "openFileDialogTask";
            // 
            // toolTipButton
            // 
            toolTipButton.ForeColor = SystemColors.Highlight;
            toolTipButton.IsBalloon = true;
            toolTipButton.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 574);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(groupBoxCondition_GVM);
            Controls.Add(buttonInfo_GVM);
            Controls.Add(buttonSaveFile_GVM);
            Controls.Add(buttonOpenFile_GVM);
            Controls.Add(buttonDone);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBoxCondition_GVM.ResumeLayout(false);
            groupBoxCondition_GVM.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDone;
        private Button buttonOpenFile_GVM;
        private Button buttonSaveFile_GVM;
        private Button buttonInfo_GVM;
        private TextBox textBox1;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TextBox textBoxCondition_GVM;
        private GroupBox groupBoxCondition_GVM;
        private OpenFileDialog openFileDialogTask_GVM;
        private ToolTip toolTipButton;
        private SaveFileDialog saveFileDialogMatrix;
    }
}
