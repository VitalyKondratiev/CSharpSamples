namespace ThreadSample
{
    partial class mainForm
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
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.stringButton = new System.Windows.Forms.Button();
            this.stringTextBox = new System.Windows.Forms.TextBox();
            this.threadListBox = new System.Windows.Forms.ListBox();
            this.stringsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(13, 13);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Thread";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(94, 13);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop Thread";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // stringButton
            // 
            this.stringButton.Location = new System.Drawing.Point(197, 42);
            this.stringButton.Name = "stringButton";
            this.stringButton.Size = new System.Drawing.Size(75, 22);
            this.stringButton.TabIndex = 2;
            this.stringButton.Text = "Add String";
            this.stringButton.UseVisualStyleBackColor = true;
            this.stringButton.Click += new System.EventHandler(this.stringButton_Click);
            // 
            // stringTextBox
            // 
            this.stringTextBox.Location = new System.Drawing.Point(13, 43);
            this.stringTextBox.Name = "stringTextBox";
            this.stringTextBox.Size = new System.Drawing.Size(178, 20);
            this.stringTextBox.TabIndex = 3;
            // 
            // threadListBox
            // 
            this.threadListBox.FormattingEnabled = true;
            this.threadListBox.Location = new System.Drawing.Point(148, 69);
            this.threadListBox.Name = "threadListBox";
            this.threadListBox.Size = new System.Drawing.Size(124, 173);
            this.threadListBox.TabIndex = 4;
            // 
            // stringsListBox
            // 
            this.stringsListBox.FormattingEnabled = true;
            this.stringsListBox.Location = new System.Drawing.Point(13, 69);
            this.stringsListBox.Name = "stringsListBox";
            this.stringsListBox.Size = new System.Drawing.Size(124, 173);
            this.stringsListBox.TabIndex = 5;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 248);
            this.Controls.Add(this.stringsListBox);
            this.Controls.Add(this.threadListBox);
            this.Controls.Add(this.stringTextBox);
            this.Controls.Add(this.stringButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThreadSample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button stringButton;
        private System.Windows.Forms.TextBox stringTextBox;
        private System.Windows.Forms.ListBox threadListBox;
        private System.Windows.Forms.ListBox stringsListBox;
    }
}

