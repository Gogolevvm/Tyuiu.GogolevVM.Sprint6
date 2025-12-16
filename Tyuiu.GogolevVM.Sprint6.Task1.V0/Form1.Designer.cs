namespace Tyuiu.GogolevVM.Sprint6.Task1.V0
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            TextStart = new TextBox();
            textBox4 = new TextBox();
            textBoxEndStep = new TextBox();
            textBoxStartStep = new TextBox();
            buttonHelp = new Button();
            buttonResult = new Button();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBoxResult = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(475, 263);
            textBox1.TabIndex = 0;
            textBox1.Text = "Условие:\r\nПротабулировать функцию sin(x) на заданном диапазоне.\r\nРезультат вывести в виде таблицы\r\n";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 327);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            textBox2.Text = "Ввод данных";
            // 
            // TextStart
            // 
            TextStart.Location = new Point(12, 360);
            TextStart.Name = "TextStart";
            TextStart.ReadOnly = true;
            TextStart.Size = new Size(125, 27);
            TextStart.TabIndex = 2;
            TextStart.Text = "Старт шага:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(174, 360);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 3;
            textBox4.Text = "Конец шага:\r\n";
            // 
            // textBoxEndStep
            // 
            textBoxEndStep.Location = new Point(174, 393);
            textBoxEndStep.Name = "textBoxEndStep";
            textBoxEndStep.Size = new Size(125, 27);
            textBoxEndStep.TabIndex = 4;
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(12, 393);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(125, 27);
            textBoxStartStep.TabIndex = 5;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.ActiveCaption;
            buttonHelp.Location = new Point(305, 360);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(94, 60);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonResult
            // 
            buttonResult.BackColor = Color.Lime;
            buttonResult.Location = new Point(405, 360);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(82, 60);
            buttonResult.TabIndex = 7;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = false;
            buttonResult.Click += buttonDone_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(493, 12);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 8;
            textBox7.Text = "Вывод данных:\r\n";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(493, 45);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 9;
            textBox8.Text = "Результат";
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(493, 78);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(316, 342);
            textBoxResult.TabIndex = 10;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxResult);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(buttonResult);
            Controls.Add(buttonHelp);
            Controls.Add(textBoxStartStep);
            Controls.Add(textBoxEndStep);
            Controls.Add(textBox4);
            Controls.Add(TextStart);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox TextStart;
        private TextBox textBox4;
        private TextBox textBoxEndStep;
        private TextBox textBoxStartStep;
        private Button buttonHelp;
        private Button buttonResult;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBoxResult;
    }
}
