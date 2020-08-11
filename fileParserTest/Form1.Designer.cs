namespace fileParserTest
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.filepathLabel = new System.Windows.Forms.Label();
            this.cleanPunctuationCheckbox = new System.Windows.Forms.CheckBox();
            this.wordLengthInput = new System.Windows.Forms.NumericUpDown();
            this.wordLengthLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.outputFilepathLabel = new System.Windows.Forms.Label();
            this.chooseFileButtonWrite = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.successLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wordLengthInput)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseFileButton.Location = new System.Drawing.Point(41, 46);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(155, 59);
            this.chooseFileButton.TabIndex = 1;
            this.chooseFileButton.Text = "Выбрать файл для чтения";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // filepathLabel
            // 
            this.filepathLabel.AutoSize = true;
            this.filepathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filepathLabel.Location = new System.Drawing.Point(202, 63);
            this.filepathLabel.Name = "filepathLabel";
            this.filepathLabel.Size = new System.Drawing.Size(60, 24);
            this.filepathLabel.TabIndex = 2;
            this.filepathLabel.Text = "label1";
            // 
            // cleanPunctuationCheckbox
            // 
            this.cleanPunctuationCheckbox.AutoSize = true;
            this.cleanPunctuationCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cleanPunctuationCheckbox.Location = new System.Drawing.Point(42, 214);
            this.cleanPunctuationCheckbox.Name = "cleanPunctuationCheckbox";
            this.cleanPunctuationCheckbox.Size = new System.Drawing.Size(271, 28);
            this.cleanPunctuationCheckbox.TabIndex = 3;
            this.cleanPunctuationCheckbox.Text = "удалить знаки препинания";
            this.cleanPunctuationCheckbox.UseVisualStyleBackColor = true;
            this.cleanPunctuationCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // wordLengthInput
            // 
            this.wordLengthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordLengthInput.Location = new System.Drawing.Point(42, 259);
            this.wordLengthInput.Name = "wordLengthInput";
            this.wordLengthInput.Size = new System.Drawing.Size(50, 29);
            this.wordLengthInput.TabIndex = 4;
            this.wordLengthInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wordLengthInput.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.wordLengthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wordLengthInput_KeyPress);
            // 
            // wordLengthLabel
            // 
            this.wordLengthLabel.AutoSize = true;
            this.wordLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordLengthLabel.Location = new System.Drawing.Point(98, 259);
            this.wordLengthLabel.Name = "wordLengthLabel";
            this.wordLengthLabel.Size = new System.Drawing.Size(409, 24);
            this.wordLengthLabel.TabIndex = 5;
            this.wordLengthLabel.Text = "минимальное количество символов в слове";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(42, 316);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(194, 42);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Начать обработку";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // outputFilepathLabel
            // 
            this.outputFilepathLabel.AutoSize = true;
            this.outputFilepathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputFilepathLabel.Location = new System.Drawing.Point(202, 147);
            this.outputFilepathLabel.Name = "outputFilepathLabel";
            this.outputFilepathLabel.Size = new System.Drawing.Size(60, 24);
            this.outputFilepathLabel.TabIndex = 8;
            this.outputFilepathLabel.Text = "label1";
            // 
            // chooseFileButtonWrite
            // 
            this.chooseFileButtonWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseFileButtonWrite.Location = new System.Drawing.Point(41, 130);
            this.chooseFileButtonWrite.Name = "chooseFileButtonWrite";
            this.chooseFileButtonWrite.Size = new System.Drawing.Size(155, 59);
            this.chooseFileButtonWrite.TabIndex = 7;
            this.chooseFileButtonWrite.Text = "Выбрать файл для записи";
            this.chooseFileButtonWrite.UseVisualStyleBackColor = true;
            this.chooseFileButtonWrite.Click += new System.EventHandler(this.chooseFileButtonWrite_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(282, 316);
            this.progressBar.Maximum = 1;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(535, 42);
            this.progressBar.TabIndex = 9;
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.successLabel.Location = new System.Drawing.Point(278, 361);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(60, 24);
            this.successLabel.TabIndex = 10;
            this.successLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 435);
            this.Controls.Add(this.successLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.outputFilepathLabel);
            this.Controls.Add(this.chooseFileButtonWrite);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.wordLengthLabel);
            this.Controls.Add(this.wordLengthInput);
            this.Controls.Add(this.cleanPunctuationCheckbox);
            this.Controls.Add(this.filepathLabel);
            this.Controls.Add(this.chooseFileButton);
            this.Name = "Form1";
            this.Text = "Обработка текста";
            ((System.ComponentModel.ISupportInitialize)(this.wordLengthInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.Label filepathLabel;
        private System.Windows.Forms.CheckBox cleanPunctuationCheckbox;
        private System.Windows.Forms.NumericUpDown wordLengthInput;
        private System.Windows.Forms.Label wordLengthLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label outputFilepathLabel;
        private System.Windows.Forms.Button chooseFileButtonWrite;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label successLabel;
    }
}

