namespace Tyuiu.GogolevVM.Sprint6.Task3.V24
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            textBoxCondition_GVM = new TextBox();
            dataGridViewMatric_GVM = new DataGridView();
            textBoxOutPut_GVM = new TextBox();
            textBoxResult_GVM = new TextBox();
            buttonHelp = new Button();
            buttonDone = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatric_GVM).BeginInit();
            SuspendLayout();
            // 
            // textBoxCondition_GVM
            // 
            textBoxCondition_GVM.Location = new Point(2, 12);
            textBoxCondition_GVM.Multiline = true;
            textBoxCondition_GVM.Name = "textBoxCondition_GVM";
            textBoxCondition_GVM.ReadOnly = true;
            textBoxCondition_GVM.Size = new Size(343, 284);
            textBoxCondition_GVM.TabIndex = 1;
            textBoxCondition_GVM.Text = resources.GetString("textBoxCondition_GVM.Text");
            // 
            // dataGridViewMatric_GVM
            // 
            dataGridViewMatric_GVM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatric_GVM.Location = new Point(377, 12);
            dataGridViewMatric_GVM.Name = "dataGridViewMatric_GVM";
            dataGridViewMatric_GVM.RowHeadersVisible = false;
            dataGridViewMatric_GVM.RowHeadersWidth = 51;
            dataGridViewMatric_GVM.Size = new Size(300, 412);
            dataGridViewMatric_GVM.TabIndex = 2;
            // 
            // textBoxOutPut_GVM
            // 
            textBoxOutPut_GVM.Location = new Point(768, 12);
            textBoxOutPut_GVM.Multiline = true;
            textBoxOutPut_GVM.Name = "textBoxOutPut_GVM";
            textBoxOutPut_GVM.ReadOnly = true;
            textBoxOutPut_GVM.Size = new Size(172, 56);
            textBoxOutPut_GVM.TabIndex = 3;
            textBoxOutPut_GVM.Text = "Вывод данных\r\nРезультат:\r\n";
            // 
            // textBoxResult_GVM
            // 
            textBoxResult_GVM.Location = new Point(768, 83);
            textBoxResult_GVM.Name = "textBoxResult_GVM";
            textBoxResult_GVM.Size = new Size(172, 27);
            textBoxResult_GVM.TabIndex = 4;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(768, 385);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(44, 29);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(833, 349);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(107, 65);
            buttonDone.TabIndex = 7;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 450);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(textBoxResult_GVM);
            Controls.Add(textBoxOutPut_GVM);
            Controls.Add(dataGridViewMatric_GVM);
            Controls.Add(textBoxCondition_GVM);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 24 | Выполнил: Гоголев В.М";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatric_GVM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCondition_GVM;
        private DataGridView dataGridViewMatric_GVM;
        private TextBox textBoxOutPut_GVM;
        private TextBox textBoxResult_GVM;
        private Button buttonHelp;
        private Button buttonDone;
    }
}
