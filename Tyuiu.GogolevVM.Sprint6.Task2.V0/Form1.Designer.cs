namespace Tyuiu.GogolevVM.Sprint6.Task2.V0
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBoxStartStep = new TextBox();
            textBoxStopStep = new TextBox();
            textBoxStart_GVM = new TextBox();
            textBoxStop_GVM = new TextBox();
            buttonHelp_GVM = new Button();
            buttonResult_GVM = new Button();
            textBoxOutput_GVM = new TextBox();
            textBoxResult_GVM = new TextBox();
            dataGridViewFunction = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(595, 77);
            textBox1.TabIndex = 0;
            textBox1.Text = "Условие\r\nПротабулировать функцию sin(x) на заданном диапазоне.\r\nРезультат вывести в DataGridView и построить функции.\r\n";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 338);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            textBox2.Text = "Ввод данных";
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(12, 371);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.ReadOnly = true;
            textBoxStartStep.Size = new Size(125, 27);
            textBoxStartStep.TabIndex = 2;
            textBoxStartStep.Text = "Старт шага:";
            // 
            // textBoxStopStep
            // 
            textBoxStopStep.Location = new Point(207, 371);
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.ReadOnly = true;
            textBoxStopStep.Size = new Size(125, 27);
            textBoxStopStep.TabIndex = 3;
            textBoxStopStep.Text = "Конец шага:";
            // 
            // textBoxStart_GVM
            // 
            textBoxStart_GVM.Location = new Point(12, 411);
            textBoxStart_GVM.Name = "textBoxStart_GVM";
            textBoxStart_GVM.Size = new Size(125, 27);
            textBoxStart_GVM.TabIndex = 4;
            // 
            // textBoxStop_GVM
            // 
            textBoxStop_GVM.Location = new Point(207, 411);
            textBoxStop_GVM.Name = "textBoxStop_GVM";
            textBoxStop_GVM.Size = new Size(125, 27);
            textBoxStop_GVM.TabIndex = 5;
            // 
            // buttonHelp_GVM
            // 
            buttonHelp_GVM.BackColor = Color.CornflowerBlue;
            buttonHelp_GVM.Location = new Point(373, 369);
            buttonHelp_GVM.Name = "buttonHelp_GVM";
            buttonHelp_GVM.Size = new Size(94, 69);
            buttonHelp_GVM.TabIndex = 6;
            buttonHelp_GVM.Text = "Справка";
            buttonHelp_GVM.UseVisualStyleBackColor = false;
            buttonHelp_GVM.Click += buttonHelp_GVM_Click;
            // 
            // buttonResult_GVM
            // 
            buttonResult_GVM.BackColor = Color.Lime;
            buttonResult_GVM.Location = new Point(500, 371);
            buttonResult_GVM.Name = "buttonResult_GVM";
            buttonResult_GVM.Size = new Size(107, 67);
            buttonResult_GVM.TabIndex = 7;
            buttonResult_GVM.Text = "Выполнить";
            buttonResult_GVM.UseVisualStyleBackColor = false;
            buttonResult_GVM.Click += buttonDone;
            buttonResult_GVM.MouseDown += buttonResult_GVM_MouseDown;
            buttonResult_GVM.MouseEnter += buttonDone_MouseEnter;
            buttonResult_GVM.MouseLeave += buttonResult_GVM_MouseLeave;
            // 
            // textBoxOutput_GVM
            // 
            textBoxOutput_GVM.Location = new Point(668, 12);
            textBoxOutput_GVM.Name = "textBoxOutput_GVM";
            textBoxOutput_GVM.ReadOnly = true;
            textBoxOutput_GVM.Size = new Size(125, 27);
            textBoxOutput_GVM.TabIndex = 8;
            textBoxOutput_GVM.Text = "Вывод данных";
            // 
            // textBoxResult_GVM
            // 
            textBoxResult_GVM.Location = new Point(668, 45);
            textBoxResult_GVM.Name = "textBoxResult_GVM";
            textBoxResult_GVM.ReadOnly = true;
            textBoxResult_GVM.Size = new Size(125, 27);
            textBoxResult_GVM.TabIndex = 9;
            textBoxResult_GVM.Text = "Результат:";
            // 
            // dataGridViewFunction
            // 
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewFunction.Location = new Point(668, 87);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.RowHeadersWidth = 51;
            dataGridViewFunction.Size = new Size(154, 351);
            dataGridViewFunction.TabIndex = 10;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.Width = 50;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(860, 87);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(375, 351);
            chart1.TabIndex = 11;
            chart1.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 450);
            Controls.Add(chart1);
            Controls.Add(dataGridViewFunction);
            Controls.Add(textBoxResult_GVM);
            Controls.Add(textBoxOutput_GVM);
            Controls.Add(buttonResult_GVM);
            Controls.Add(buttonHelp_GVM);
            Controls.Add(textBoxStop_GVM);
            Controls.Add(textBoxStart_GVM);
            Controls.Add(textBoxStopStep);
            Controls.Add(textBoxStartStep);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 0 | Гоголев.В.М";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBoxStartStep;
        private TextBox textBoxStopStep;
        private TextBox textBoxStart_GVM;
        private TextBox textBoxStop_GVM;
        private Button buttonHelp_GVM;
        private Button buttonResult_GVM;
        private TextBox textBoxOutput_GVM;
        private TextBox textBoxResult_GVM;
        private DataGridView dataGridViewFunction;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
