namespace Tyuiu.GogolevVM.Sprint6.Task0.V0
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
            textBox1 = new TextBox();
            textBoxTask = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBoxResult = new TextBox();
            textBoxVarA = new TextBox();
            textBoxVarB = new TextBox();
            textBoxVarC = new TextBox();
            buttonDone = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(70, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Условие:\r\n\r\n";
            // 
            // textBoxTask
            // 
            textBoxTask.Font = new Font("Arial", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxTask.Location = new Point(12, 58);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(507, 169);
            textBoxTask.TabIndex = 1;
            textBoxTask.Text = "Вычислить выражение по формуле: ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 268);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(132, 27);
            textBox3.TabIndex = 2;
            textBox3.Text = "Ввод данных";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(623, 268);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(106, 27);
            textBox4.TabIndex = 3;
            textBox4.Text = "Вывод данных";
            textBox4.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 320);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 4;
            textBox5.Text = "Переменная A:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(202, 320);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 5;
            textBox6.Text = "Переменная B:\r\n";
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(394, 320);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 6;
            textBox7.Text = "Переменная C:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(623, 320);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 7;
            textBox8.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(623, 379);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(125, 27);
            textBoxResult.TabIndex = 8;
            // 
            // textBoxVarA
            // 
            textBoxVarA.Location = new Point(12, 379);
            textBoxVarA.Name = "textBoxVarA";
            textBoxVarA.Size = new Size(125, 27);
            textBoxVarA.TabIndex = 9;
            textBoxVarA.TextChanged += textBox10_TextChanged;
            textBoxVarA.KeyPress += textBoxVarA_KeyPress;
            // 
            // textBoxVarB
            // 
            textBoxVarB.Location = new Point(202, 379);
            textBoxVarB.Name = "textBoxVarB";
            textBoxVarB.Size = new Size(125, 27);
            textBoxVarB.TabIndex = 10;
            textBoxVarB.KeyPress += textBoxVarA_KeyPress;
            // 
            // textBoxVarC
            // 
            textBoxVarC.Location = new Point(394, 379);
            textBoxVarC.Name = "textBoxVarC";
            textBoxVarC.Size = new Size(125, 27);
            textBoxVarC.TabIndex = 11;
            textBoxVarC.KeyPress += textBoxVarA_KeyPress;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(679, 412);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(109, 29);
            buttonDone.TabIndex = 12;
            buttonDone.Text = "Выполнить\r\n";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // button2
            // 
            button2.Location = new Point(604, 412);
            button2.Name = "button2";
            button2.Size = new Size(69, 29);
            button2.TabIndex = 13;
            button2.Text = "?\r\n\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonHelp;
            button2.KeyPress += buttonHelp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(buttonDone);
            Controls.Add(textBoxVarC);
            Controls.Add(textBoxVarB);
            Controls.Add(textBoxVarA);
            Controls.Add(textBoxResult);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBoxTask);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBoxTask;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBoxResult;
        private TextBox textBoxVarA;
        private TextBox textBoxVarB;
        private TextBox textBoxVarC;
        private Button buttonDone;
        private Button button2;
    }
}
