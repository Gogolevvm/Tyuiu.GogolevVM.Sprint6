namespace Tyuiu.GogolevVM.Sprint6.Task5.V0
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            textBoxCondition_GVM = new TextBox();
            textBoxData_GVM = new TextBox();
            textBox1 = new TextBox();
            dataGridViewResult_GVM = new DataGridView();
            chartDiag_GVM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonDone_GVM = new Button();
            buttonFile_GVM = new Button();
            buttonInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_GVM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag_GVM).BeginInit();
            SuspendLayout();
            // 
            // textBoxCondition_GVM
            // 
            textBoxCondition_GVM.Location = new Point(12, 0);
            textBoxCondition_GVM.Name = "textBoxCondition_GVM";
            textBoxCondition_GVM.ReadOnly = true;
            textBoxCondition_GVM.Size = new Size(125, 27);
            textBoxCondition_GVM.TabIndex = 0;
            textBoxCondition_GVM.Text = "Условие:";
            // 
            // textBoxData_GVM
            // 
            textBoxData_GVM.Location = new Point(12, 33);
            textBoxData_GVM.Multiline = true;
            textBoxData_GVM.Name = "textBoxData_GVM";
            textBoxData_GVM.ReadOnly = true;
            textBoxData_GVM.Size = new Size(593, 57);
            textBoxData_GVM.TabIndex = 1;
            textBoxData_GVM.Text = "Прочитать данные из файла InPutFileTask5.txt. Вывести в dataGridView\r\nположительные значения и построить диаграмму по этим значениям.\r\n";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 96);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            textBox1.Text = "Вывод данных:";
            // 
            // dataGridViewResult_GVM
            // 
            dataGridViewResult_GVM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_GVM.Location = new Point(12, 129);
            dataGridViewResult_GVM.Name = "dataGridViewResult_GVM";
            dataGridViewResult_GVM.RowHeadersWidth = 51;
            dataGridViewResult_GVM.Size = new Size(125, 309);
            dataGridViewResult_GVM.TabIndex = 4;
            // 
            // chartDiag_GVM
            // 
            chartArea1.Name = "ChartArea1";
            chartDiag_GVM.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDiag_GVM.Legends.Add(legend1);
            chartDiag_GVM.Location = new Point(158, 96);
            chartDiag_GVM.Name = "chartDiag_GVM";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiag_GVM.Series.Add(series1);
            chartDiag_GVM.Size = new Size(447, 342);
            chartDiag_GVM.TabIndex = 5;
            chartDiag_GVM.Text = "chart1";
            // 
            // buttonDone_GVM
            // 
            buttonDone_GVM.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone_GVM.Location = new Point(611, 32);
            buttonDone_GVM.Name = "buttonDone_GVM";
            buttonDone_GVM.Size = new Size(98, 58);
            buttonDone_GVM.TabIndex = 6;
            buttonDone_GVM.Text = "Выполнить";
            buttonDone_GVM.UseVisualStyleBackColor = false;
            buttonDone_GVM.Click += buttonDone_GVM_Click;
            // 
            // buttonFile_GVM
            // 
            buttonFile_GVM.BackColor = Color.FromArgb(128, 128, 255);
            buttonFile_GVM.Location = new Point(715, 33);
            buttonFile_GVM.Name = "buttonFile_GVM";
            buttonFile_GVM.Size = new Size(94, 57);
            buttonFile_GVM.TabIndex = 7;
            buttonFile_GVM.Text = "Открыть файл";
            buttonFile_GVM.UseVisualStyleBackColor = false;
            buttonFile_GVM.Click += buttonFile_GVM_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = Color.Cyan;
            buttonInfo.Location = new Point(815, 32);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(110, 58);
            buttonInfo.TabIndex = 8;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 450);
            Controls.Add(buttonInfo);
            Controls.Add(buttonFile_GVM);
            Controls.Add(buttonDone_GVM);
            Controls.Add(chartDiag_GVM);
            Controls.Add(dataGridViewResult_GVM);
            Controls.Add(textBox1);
            Controls.Add(textBoxData_GVM);
            Controls.Add(textBoxCondition_GVM);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_GVM).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag_GVM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCondition_GVM;
        private TextBox textBoxData_GVM;
        private TextBox textBox1;
        private DataGridView dataGridViewResult_GVM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_GVM;
        private Button buttonDone_GVM;
        private Button buttonFile_GVM;
        private Button buttonInfo;
    }
}
