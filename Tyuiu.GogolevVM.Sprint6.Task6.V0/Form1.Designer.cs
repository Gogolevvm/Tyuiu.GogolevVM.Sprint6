namespace Tyuiu.GogolevVM.Sprint6.Task6.V0
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
            components = new System.ComponentModel.Container();
            openFileDialogTask = new OpenFileDialog();
            toolTip = new ToolTip(components);
            buttonOpenFile = new Button();
            textBox1 = new TextBox();
            textBoxLoadFromFile = new TextBox();
            textBoxREsult = new TextBox();
            button2 = new Button();
            buttonHelp = new Button();
            SuspendLayout();
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTip
            // 
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(12, 12);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(110, 60);
            buttonOpenFile.TabIndex = 3;
            buttonOpenFile.Text = "button1";
            toolTip.SetToolTip(buttonOpenFile, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 78);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(466, 28);
            textBox1.TabIndex = 0;
            textBox1.Text = "Условие";
            // 
            // textBoxLoadFromFile
            // 
            textBoxLoadFromFile.Location = new Point(11, 121);
            textBoxLoadFromFile.Multiline = true;
            textBoxLoadFromFile.Name = "textBoxLoadFromFile";
            textBoxLoadFromFile.ScrollBars = ScrollBars.Vertical;
            textBoxLoadFromFile.Size = new Size(281, 322);
            textBoxLoadFromFile.TabIndex = 1;
            textBoxLoadFromFile.TextChanged += textBox2_TextChanged;
            // 
            // textBoxREsult
            // 
            textBoxREsult.Location = new Point(354, 121);
            textBoxREsult.Multiline = true;
            textBoxREsult.Name = "textBoxREsult";
            textBoxREsult.ScrollBars = ScrollBars.Vertical;
            textBoxREsult.Size = new Size(387, 322);
            textBoxREsult.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(155, 12);
            button2.Name = "button2";
            button2.Size = new Size(94, 60);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(1020, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(147, 45);
            buttonHelp.TabIndex = 5;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 450);
            Controls.Add(buttonHelp);
            Controls.Add(button2);
            Controls.Add(buttonOpenFile);
            Controls.Add(textBoxREsult);
            Controls.Add(textBoxLoadFromFile);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTip;
        private TextBox textBox1;
        private TextBox textBoxLoadFromFile;
        private TextBox textBoxREsult;
        private Button buttonOpenFile;
        private Button button2;
        private Button buttonHelp;
    }
}
