namespace Tyuiu.GogolevVM.Sprint6.Task0.V22
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
            textBoxInput = new TextBox();
            textBoxVarX_GVM = new TextBox();
            textBoxOutput_GVM = new TextBox();
            textBoxResult_GVM = new TextBox();
            textBoxVarA = new TextBox();
            textBoxResult = new TextBox();
            pictureBoxCondition_GVM = new PictureBox();
            ButtonDone_GVM = new Button();
            buttonHelp_GVM = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition_GVM).BeginInit();
            SuspendLayout();
            // 
            // textBoxCondition_GVM
            // 
            textBoxCondition_GVM.Location = new Point(12, 58);
            textBoxCondition_GVM.Multiline = true;
            textBoxCondition_GVM.Name = "textBoxCondition_GVM";
            textBoxCondition_GVM.ReadOnly = true;
            textBoxCondition_GVM.Size = new Size(520, 212);
            textBoxCondition_GVM.TabIndex = 1;
            textBoxCondition_GVM.Text = "Условие: Выписать выражение по формуле:";
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(12, 290);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.ReadOnly = true;
            textBoxInput.Size = new Size(125, 27);
            textBoxInput.TabIndex = 2;
            textBoxInput.Text = "Ввод данных";
            // 
            // textBoxVarX_GVM
            // 
            textBoxVarX_GVM.Location = new Point(12, 332);
            textBoxVarX_GVM.Name = "textBoxVarX_GVM";
            textBoxVarX_GVM.ReadOnly = true;
            textBoxVarX_GVM.Size = new Size(125, 27);
            textBoxVarX_GVM.TabIndex = 3;
            textBoxVarX_GVM.Text = "Переменная X:";
            // 
            // textBoxOutput_GVM
            // 
            textBoxOutput_GVM.Location = new Point(622, 290);
            textBoxOutput_GVM.Name = "textBoxOutput_GVM";
            textBoxOutput_GVM.ReadOnly = true;
            textBoxOutput_GVM.Size = new Size(166, 27);
            textBoxOutput_GVM.TabIndex = 6;
            textBoxOutput_GVM.Text = "Вывод данных";
            // 
            // textBoxResult_GVM
            // 
            textBoxResult_GVM.Location = new Point(622, 332);
            textBoxResult_GVM.Name = "textBoxResult_GVM";
            textBoxResult_GVM.ReadOnly = true;
            textBoxResult_GVM.Size = new Size(166, 27);
            textBoxResult_GVM.TabIndex = 7;
            textBoxResult_GVM.Text = "Результат:";
            // 
            // textBoxVarA
            // 
            textBoxVarA.Location = new Point(12, 365);
            textBoxVarA.Name = "textBoxVarA";
            textBoxVarA.Size = new Size(125, 27);
            textBoxVarA.TabIndex = 8;
            textBoxVarA.KeyPress += textBoxVarA_KeyPress;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(622, 365);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(166, 27);
            textBoxResult.TabIndex = 11;
            // 
            // pictureBoxCondition_GVM
            // 
            pictureBoxCondition_GVM.Image = (Image)resources.GetObject("pictureBoxCondition_GVM.Image");
            pictureBoxCondition_GVM.Location = new Point(552, 58);
            pictureBoxCondition_GVM.Name = "pictureBoxCondition_GVM";
            pictureBoxCondition_GVM.Size = new Size(236, 212);
            pictureBoxCondition_GVM.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCondition_GVM.TabIndex = 12;
            pictureBoxCondition_GVM.TabStop = false;
            // 
            // ButtonDone_GVM
            // 
            ButtonDone_GVM.Location = new Point(684, 409);
            ButtonDone_GVM.Name = "ButtonDone_GVM";
            ButtonDone_GVM.Size = new Size(104, 29);
            ButtonDone_GVM.TabIndex = 13;
            ButtonDone_GVM.Text = "Выполнить";
            ButtonDone_GVM.UseVisualStyleBackColor = true;
            ButtonDone_GVM.Click += ButtonDone_GVM_Click;
            // 
            // buttonHelp_GVM
            // 
            buttonHelp_GVM.Location = new Point(622, 409);
            buttonHelp_GVM.Name = "buttonHelp_GVM";
            buttonHelp_GVM.Size = new Size(56, 29);
            buttonHelp_GVM.TabIndex = 14;
            buttonHelp_GVM.Text = "?";
            buttonHelp_GVM.UseVisualStyleBackColor = true;
            buttonHelp_GVM.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_GVM);
            Controls.Add(ButtonDone_GVM);
            Controls.Add(pictureBoxCondition_GVM);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxVarA);
            Controls.Add(textBoxResult_GVM);
            Controls.Add(textBoxOutput_GVM);
            Controls.Add(textBoxVarX_GVM);
            Controls.Add(textBoxInput);
            Controls.Add(textBoxCondition_GVM);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 22 | Гоголев.В.М";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition_GVM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCondition_GVM;
        private TextBox textBoxInput;
        private TextBox textBoxVarX_GVM;
        private TextBox textBoxOutput_GVM;
        private TextBox textBoxResult_GVM;
        private TextBox textBoxVarA;
        private TextBox textBoxResult;
        private PictureBox pictureBoxCondition_GVM;
        private Button ButtonDone_GVM;
        private Button buttonHelp_GVM;
    }
}
