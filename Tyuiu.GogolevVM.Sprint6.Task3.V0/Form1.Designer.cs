namespace Tyuiu.GogolevVM.Sprint6.Task3.V0
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
            textBoxCondition_GVM = new TextBox();
            dataGridViewMatric_GVM = new DataGridView();
            textBoxOutPut_GVM = new TextBox();
            textBoxResult_GVM = new TextBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatric_GVM).BeginInit();
            SuspendLayout();
            // 
            // textBoxCondition_GVM
            // 
            textBoxCondition_GVM.Location = new Point(12, 12);
            textBoxCondition_GVM.Multiline = true;
            textBoxCondition_GVM.Name = "textBoxCondition_GVM";
            textBoxCondition_GVM.ReadOnly = true;
            textBoxCondition_GVM.Size = new Size(330, 134);
            textBoxCondition_GVM.TabIndex = 0;
            textBoxCondition_GVM.Text = "Условие:\r\nДана матрица 3 на 3\r\n0 1 2\r\n3 0 5\r\n3 4 5\r\nподсчитать количество нулей";
            // 
            // dataGridViewMatric_GVM
            // 
            dataGridViewMatric_GVM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatric_GVM.Location = new Point(360, 12);
            dataGridViewMatric_GVM.Name = "dataGridViewMatric_GVM";
            dataGridViewMatric_GVM.RowHeadersVisible = false;
            dataGridViewMatric_GVM.RowHeadersWidth = 51;
            dataGridViewMatric_GVM.Size = new Size(300, 412);
            dataGridViewMatric_GVM.TabIndex = 1;
            // 
            // textBoxOutPut_GVM
            // 
            textBoxOutPut_GVM.Location = new Point(740, 12);
            textBoxOutPut_GVM.Multiline = true;
            textBoxOutPut_GVM.Name = "textBoxOutPut_GVM";
            textBoxOutPut_GVM.ReadOnly = true;
            textBoxOutPut_GVM.Size = new Size(172, 56);
            textBoxOutPut_GVM.TabIndex = 2;
            textBoxOutPut_GVM.Text = "Вывод данных\r\nРезультат:\r\n";
            // 
            // textBoxResult_GVM
            // 
            textBoxResult_GVM.Location = new Point(740, 88);
            textBoxResult_GVM.Name = "textBoxResult_GVM";
            textBoxResult_GVM.Size = new Size(172, 27);
            textBoxResult_GVM.TabIndex = 3;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(805, 359);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(107, 65);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(705, 395);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(44, 29);
            buttonHelp.TabIndex = 5;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 450);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(textBoxResult_GVM);
            Controls.Add(textBoxOutPut_GVM);
            Controls.Add(dataGridViewMatric_GVM);
            Controls.Add(textBoxCondition_GVM);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatric_GVM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCondition_GVM;
        private DataGridView dataGridViewMatric_GVM;
        private TextBox textBoxOutPut_GVM;
        private TextBox textBoxResult_GVM;
        private Button buttonDone;
        private Button buttonHelp;
    }
}
