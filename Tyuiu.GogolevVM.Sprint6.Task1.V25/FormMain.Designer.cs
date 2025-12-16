namespace Tyuiu.GogolevVM.Sprint6.Task1.V25
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
            textBoxCondition_GVM = new TextBox();
            textBoxInput_GVM = new TextBox();
            TextStart = new TextBox();
            textBoxEnd = new TextBox();
            buttonHelp = new Button();
            buttonResult = new Button();
            textBoxStartStep = new TextBox();
            textBoxEndStep = new TextBox();
            textBoxResult = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            SuspendLayout();
            // 
            // textBoxCondition_GVM
            // 
            textBoxCondition_GVM.Location = new Point(12, 12);
            textBoxCondition_GVM.Multiline = true;
            textBoxCondition_GVM.Name = "textBoxCondition_GVM";
            textBoxCondition_GVM.ReadOnly = true;
            textBoxCondition_GVM.Size = new Size(440, 263);
            textBoxCondition_GVM.TabIndex = 1;
            textBoxCondition_GVM.Text = "Условие:\r\nПротабулировать функцию (5x + 2,5)/(sinx - 2) + 2 на заданном диапазоне.\r\nРезультат вывести в виде таблицы.\r\n\r\n";
            // 
            // textBoxInput_GVM
            // 
            textBoxInput_GVM.Location = new Point(12, 281);
            textBoxInput_GVM.Name = "textBoxInput_GVM";
            textBoxInput_GVM.ReadOnly = true;
            textBoxInput_GVM.Size = new Size(125, 27);
            textBoxInput_GVM.TabIndex = 2;
            textBoxInput_GVM.Text = "Ввод данных";
            // 
            // TextStart
            // 
            TextStart.Location = new Point(12, 314);
            TextStart.Name = "TextStart";
            TextStart.ReadOnly = true;
            TextStart.Size = new Size(125, 27);
            TextStart.TabIndex = 3;
            TextStart.Text = "Старт шага:";
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(186, 314);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.ReadOnly = true;
            textBoxEnd.Size = new Size(125, 27);
            textBoxEnd.TabIndex = 4;
            textBoxEnd.Text = "Конец шага:\r\n";
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.ActiveCaption;
            buttonHelp.Location = new Point(317, 318);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(94, 60);
            buttonHelp.TabIndex = 7;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonResult
            // 
            buttonResult.BackColor = Color.Lime;
            buttonResult.Location = new Point(317, 384);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(94, 60);
            buttonResult.TabIndex = 8;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = false;
            buttonResult.Click += ButtonResult_Click;
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(12, 351);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(125, 27);
            textBoxStartStep.TabIndex = 9;
            // 
            // textBoxEndStep
            // 
            textBoxEndStep.Location = new Point(186, 347);
            textBoxEndStep.Name = "textBoxEndStep";
            textBoxEndStep.Size = new Size(125, 27);
            textBoxEndStep.TabIndex = 10;
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(472, 102);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(316, 342);
            textBoxResult.TabIndex = 11;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(472, 12);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 12;
            textBox7.Text = "Вывод данных:\r\n";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(472, 45);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 13;
            textBox8.Text = "Результат";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxEndStep);
            Controls.Add(textBoxStartStep);
            Controls.Add(buttonResult);
            Controls.Add(buttonHelp);
            Controls.Add(textBoxEnd);
            Controls.Add(TextStart);
            Controls.Add(textBoxInput_GVM);
            Controls.Add(textBoxCondition_GVM);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 25 | Гоголев В.М";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCondition_GVM;
        private TextBox textBoxInput_GVM;
        private TextBox TextStart;
        private TextBox textBoxEnd;
        private Button buttonHelp;
        private Button buttonResult;
        private TextBox textBoxStartStep;
        private TextBox textBoxEndStep;
        private TextBox textBoxResult;
        private TextBox textBox7;
        private TextBox textBox8;
    }
}
