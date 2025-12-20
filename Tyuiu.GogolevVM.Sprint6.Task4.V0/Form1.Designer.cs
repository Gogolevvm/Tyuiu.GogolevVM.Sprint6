namespace Tyuiu.GogolevVM.Sprint6.Task4.V0
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBoxData_GVM = new TextBox();
            textBoxConclusion = new TextBox();
            textBoxResult_GVM = new TextBox();
            textBoxStart_GVM = new TextBox();
            textBoxEnd_GVM = new TextBox();
            textBoxStartStep_GVM = new TextBox();
            textBoxStopStep_GVM = new TextBox();
            buttonDone = new Button();
            buttonSave = new Button();
            buttonInfo = new Button();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1, 40);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(577, 70);
            textBox1.TabIndex = 0;
            textBox1.Text = "Протабулировать функцию sin(x) на заданном диапазоне от -5 до 5.\r\nРезультат вывести в textBox, построить график функции и сохранить в файл \r\nOutPutFileTask.txt по нажатию кнопки\r\n";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1, 7);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            textBox2.Text = "Условие:";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBoxData_GVM
            // 
            textBoxData_GVM.Location = new Point(580, 7);
            textBoxData_GVM.Name = "textBoxData_GVM";
            textBoxData_GVM.ReadOnly = true;
            textBoxData_GVM.Size = new Size(125, 27);
            textBoxData_GVM.TabIndex = 2;
            textBoxData_GVM.Text = "Ввод данных";
            // 
            // textBoxConclusion
            // 
            textBoxConclusion.Location = new Point(1, 130);
            textBoxConclusion.Name = "textBoxConclusion";
            textBoxConclusion.ReadOnly = true;
            textBoxConclusion.Size = new Size(125, 27);
            textBoxConclusion.TabIndex = 3;
            textBoxConclusion.Text = "Вывод:";
            // 
            // textBoxResult_GVM
            // 
            textBoxResult_GVM.Location = new Point(1, 163);
            textBoxResult_GVM.Multiline = true;
            textBoxResult_GVM.Name = "textBoxResult_GVM";
            textBoxResult_GVM.ReadOnly = true;
            textBoxResult_GVM.ScrollBars = ScrollBars.Vertical;
            textBoxResult_GVM.Size = new Size(253, 281);
            textBoxResult_GVM.TabIndex = 4;
            // 
            // textBoxStart_GVM
            // 
            textBoxStart_GVM.Location = new Point(580, 40);
            textBoxStart_GVM.Name = "textBoxStart_GVM";
            textBoxStart_GVM.ReadOnly = true;
            textBoxStart_GVM.Size = new Size(125, 27);
            textBoxStart_GVM.TabIndex = 5;
            textBoxStart_GVM.Text = "Старт шага:";
            // 
            // textBoxEnd_GVM
            // 
            textBoxEnd_GVM.Location = new Point(711, 40);
            textBoxEnd_GVM.Name = "textBoxEnd_GVM";
            textBoxEnd_GVM.ReadOnly = true;
            textBoxEnd_GVM.Size = new Size(125, 27);
            textBoxEnd_GVM.TabIndex = 6;
            textBoxEnd_GVM.Text = "Конец шага:";
            // 
            // textBoxStartStep_GVM
            // 
            textBoxStartStep_GVM.Location = new Point(580, 73);
            textBoxStartStep_GVM.Name = "textBoxStartStep_GVM";
            textBoxStartStep_GVM.Size = new Size(125, 27);
            textBoxStartStep_GVM.TabIndex = 7;
            // 
            // textBoxStopStep_GVM
            // 
            textBoxStopStep_GVM.Location = new Point(711, 73);
            textBoxStopStep_GVM.Name = "textBoxStopStep_GVM";
            textBoxStopStep_GVM.Size = new Size(125, 27);
            textBoxStopStep_GVM.TabIndex = 8;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Lime;
            buttonDone.Location = new Point(842, 38);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(104, 62);
            buttonDone.TabIndex = 9;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Cyan;
            buttonSave.Location = new Point(952, 40);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 60);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = Color.Teal;
            buttonInfo.Location = new Point(1087, 40);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(94, 60);
            buttonInfo.TabIndex = 11;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(285, 130);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(761, 314);
            chartFunction.TabIndex = 12;
            chartFunction.Text = "chartFunction";
            title1.Name = "TitleSin";
            title1.Text = "График функции sin(x)";
            chartFunction.Titles.Add(title1);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 450);
            Controls.Add(chartFunction);
            Controls.Add(buttonInfo);
            Controls.Add(buttonSave);
            Controls.Add(buttonDone);
            Controls.Add(textBoxStopStep_GVM);
            Controls.Add(textBoxStartStep_GVM);
            Controls.Add(textBoxEnd_GVM);
            Controls.Add(textBoxStart_GVM);
            Controls.Add(textBoxResult_GVM);
            Controls.Add(textBoxConclusion);
            Controls.Add(textBoxData_GVM);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            MinimumSize = new Size(1211, 497);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBoxData_GVM;
        private TextBox textBoxConclusion;
        private TextBox textBoxResult_GVM;
        private TextBox textBoxStart_GVM;
        private TextBox textBoxEnd_GVM;
        private TextBox textBoxStartStep_GVM;
        private TextBox textBoxStopStep_GVM;
        private Button buttonDone;
        private Button buttonSave;
        private Button buttonInfo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}
