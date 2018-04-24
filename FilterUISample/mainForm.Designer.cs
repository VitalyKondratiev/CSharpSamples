namespace FilterUISample
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
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.mainFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.newFilterComboBox = new System.Windows.Forms.ComboBox();
            this.newFilterButton = new System.Windows.Forms.Button();
            this.filterCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.mainFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainDataGridView.Location = new System.Drawing.Point(0, 0);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.Size = new System.Drawing.Size(460, 180);
            this.mainDataGridView.TabIndex = 0;
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainSplitContainer.IsSplitterFixed = true;
            this.mainSplitContainer.Location = new System.Drawing.Point(12, 27);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.mainFlowLayoutPanel);
            this.mainSplitContainer.Panel1MinSize = 22;
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.mainDataGridView);
            this.mainSplitContainer.Panel2MinSize = 22;
            this.mainSplitContainer.Size = new System.Drawing.Size(460, 223);
            this.mainSplitContainer.SplitterDistance = 39;
            this.mainSplitContainer.TabIndex = 1;
            // 
            // mainFlowLayoutPanel
            // 
            this.mainFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainFlowLayoutPanel.AutoSize = true;
            this.mainFlowLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainFlowLayoutPanel.Controls.Add(this.newFilterComboBox);
            this.mainFlowLayoutPanel.Controls.Add(this.newFilterButton);
            this.mainFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.mainFlowLayoutPanel.Name = "mainFlowLayoutPanel";
            this.mainFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(2);
            this.mainFlowLayoutPanel.Size = new System.Drawing.Size(454, 32);
            this.mainFlowLayoutPanel.TabIndex = 0;
            this.mainFlowLayoutPanel.SizeChanged += new System.EventHandler(this.mainFlowLayoutPanel_SizeChanged);
            this.mainFlowLayoutPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.mainFlowLayoutPanel_ControlAdded);
            this.mainFlowLayoutPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.mainFlowLayoutPanel_ControlRemoved);
            // 
            // newFilterComboBox
            // 
            this.newFilterComboBox.FormattingEnabled = true;
            this.newFilterComboBox.Items.AddRange(new object[] {
            "name",
            "state",
            "price",
            "time"});
            this.newFilterComboBox.Location = new System.Drawing.Point(5, 5);
            this.newFilterComboBox.Name = "newFilterComboBox";
            this.newFilterComboBox.Size = new System.Drawing.Size(121, 21);
            this.newFilterComboBox.TabIndex = 1;
            // 
            // newFilterButton
            // 
            this.mainFlowLayoutPanel.SetFlowBreak(this.newFilterButton, true);
            this.newFilterButton.Location = new System.Drawing.Point(132, 5);
            this.newFilterButton.Name = "newFilterButton";
            this.newFilterButton.Size = new System.Drawing.Size(75, 22);
            this.newFilterButton.TabIndex = 2;
            this.newFilterButton.Text = "Add Filter";
            this.newFilterButton.UseVisualStyleBackColor = true;
            this.newFilterButton.Click += new System.EventHandler(this.newFilterButton_Click);
            // 
            // filterCheckBox
            // 
            this.filterCheckBox.AutoSize = true;
            this.filterCheckBox.Location = new System.Drawing.Point(12, 4);
            this.filterCheckBox.Name = "filterCheckBox";
            this.filterCheckBox.Size = new System.Drawing.Size(53, 17);
            this.filterCheckBox.TabIndex = 2;
            this.filterCheckBox.Text = "Filters";
            this.filterCheckBox.UseVisualStyleBackColor = true;
            this.filterCheckBox.CheckedChanged += new System.EventHandler(this.filterCheckBox_CheckedChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.filterCheckBox);
            this.Controls.Add(this.mainSplitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(312, 39);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilterUISample";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel1.PerformLayout();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.mainFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mainDataGridView;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.CheckBox filterCheckBox;
        private System.Windows.Forms.FlowLayoutPanel mainFlowLayoutPanel;
        private System.Windows.Forms.ComboBox newFilterComboBox;
        private System.Windows.Forms.Button newFilterButton;
    }
}

