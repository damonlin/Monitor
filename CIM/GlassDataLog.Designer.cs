namespace CIM
{
    partial class GlassDataLog
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該公開 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.logFolderTextBox = new System.Windows.Forms.TextBox();
            this.selectLogFileFolderButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.historyLogTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Log|*.log";
            // 
            // logFolderTextBox
            // 
            this.logFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.logFolderTextBox.BackColor = System.Drawing.Color.White;
            this.logFolderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logFolderTextBox.Font = new System.Drawing.Font("Verdana", 9.936297F);
            this.logFolderTextBox.Location = new System.Drawing.Point(17, 22);
            this.logFolderTextBox.Name = "logFolderTextBox";
            this.logFolderTextBox.ReadOnly = true;
            this.logFolderTextBox.Size = new System.Drawing.Size(1033, 24);
            this.logFolderTextBox.TabIndex = 0;
            // 
            // selectLogFileFolderButton
            // 
            this.selectLogFileFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectLogFileFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectLogFileFolderButton.Font = new System.Drawing.Font("Verdana", 9.171968F);
            this.selectLogFileFolderButton.Location = new System.Drawing.Point(1051, 22);
            this.selectLogFileFolderButton.Name = "selectLogFileFolderButton";
            this.selectLogFileFolderButton.Size = new System.Drawing.Size(33, 23);
            this.selectLogFileFolderButton.TabIndex = 8;
            this.selectLogFileFolderButton.Text = "...";
            this.selectLogFileFolderButton.UseVisualStyleBackColor = true;
            this.selectLogFileFolderButton.Click += new System.EventHandler(this.selectLogFileFolderButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.selectLogFileFolderButton);
            this.groupBox1.Controls.Add(this.logFolderTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1105, 57);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log file directory";
            // 
            // historyLogTextBox
            // 
            this.historyLogTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.historyLogTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.historyLogTextBox.BackColor = System.Drawing.Color.White;
            this.historyLogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.historyLogTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyLogTextBox.Location = new System.Drawing.Point(3, 68);
            this.historyLogTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.historyLogTextBox.Multiline = true;
            this.historyLogTextBox.Name = "historyLogTextBox";
            this.historyLogTextBox.ReadOnly = true;
            this.historyLogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.historyLogTextBox.Size = new System.Drawing.Size(1103, 995);
            this.historyLogTextBox.TabIndex = 47;
            this.historyLogTextBox.WordWrap = false;
            // 
            // GlassDataLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.historyLogTextBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "GlassDataLog";
            this.Size = new System.Drawing.Size(1111, 1068);
            this.SystemDPI = Common.Template.DPI._1280_1024_;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox logFolderTextBox;
        private System.Windows.Forms.Button selectLogFileFolderButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox historyLogTextBox;
    }
}
