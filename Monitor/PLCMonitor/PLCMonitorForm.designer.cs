namespace Monitor
{
   partial class PLCMonitorForm
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

      #region Windows Form 設計工具產生的程式碼

      /// <summary>
      /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
      ///
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
         this.exitButton = new System.Windows.Forms.Button();
         this.level1TabControlEX = new Dotnetrix.Controls.TabControlEX();
         this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
         this.tabControlEX2 = new Dotnetrix.Controls.TabControlEX();
         this.tabPageEX3 = new Dotnetrix.Controls.TabPageEX();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.refreshTimer = new System.Windows.Forms.Timer(this.components);
         this.enableDetailsCheckBox = new System.Windows.Forms.CheckBox();
         this.findWhatButton = new System.Windows.Forms.Button();
         this.findWhatTextBox = new System.Windows.Forms.TextBox();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.level1TabControlEX.SuspendLayout();
         this.tabPageEX1.SuspendLayout();
         this.tabControlEX2.SuspendLayout();
         this.tabPageEX3.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.SuspendLayout();
         // 
         // exitButton
         // 
         this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.exitButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.exitButton.Location = new System.Drawing.Point(807, 500);
         this.exitButton.Name = "exitButton";
         this.exitButton.Size = new System.Drawing.Size(90, 45);
         this.exitButton.TabIndex = 3;
         this.exitButton.Text = "Close";
         this.exitButton.UseVisualStyleBackColor = true;
         this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
         // 
         // level1TabControlEX
         // 
         this.level1TabControlEX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.level1TabControlEX.Appearance = Dotnetrix.Controls.TabAppearanceEX.FlatTab;
         this.level1TabControlEX.Controls.Add(this.tabPageEX1);
         this.level1TabControlEX.ItemSize = new System.Drawing.Size(91, 40);
         this.level1TabControlEX.Location = new System.Drawing.Point(7, 7);
         this.level1TabControlEX.Name = "level1TabControlEX";
         this.level1TabControlEX.SelectedIndex = 0;
         this.level1TabControlEX.SelectedTabFontStyle = System.Drawing.FontStyle.Bold;
         this.level1TabControlEX.Size = new System.Drawing.Size(890, 487);
         this.level1TabControlEX.TabIndex = 4;
         this.level1TabControlEX.UseVisualStyles = false;
         this.level1TabControlEX.SelectedIndexChanged += new System.EventHandler(this.level1TabControlEX_SelectedIndexChanged);
         // 
         // tabPageEX1
         // 
         this.tabPageEX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(213)))), ((int)(((byte)(196)))));
         this.tabPageEX1.Controls.Add(this.tabControlEX2);
         this.tabPageEX1.Location = new System.Drawing.Point(4, 44);
         this.tabPageEX1.Name = "tabPageEX1";
         this.tabPageEX1.Size = new System.Drawing.Size(882, 439);
         this.tabPageEX1.TabIndex = 0;
         this.tabPageEX1.Text = "tabPageEX1";
         // 
         // tabControlEX2
         // 
         this.tabControlEX2.Appearance = Dotnetrix.Controls.TabAppearanceEX.FlatButton;
         this.tabControlEX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
         this.tabControlEX2.Controls.Add(this.tabPageEX3);
         this.tabControlEX2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tabControlEX2.Location = new System.Drawing.Point(0, 0);
         this.tabControlEX2.Name = "tabControlEX2";
         this.tabControlEX2.SelectedIndex = 0;
         this.tabControlEX2.SelectedTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
         this.tabControlEX2.SelectedTabFontStyle = System.Drawing.FontStyle.Bold;
         this.tabControlEX2.Size = new System.Drawing.Size(882, 439);
         this.tabControlEX2.TabIndex = 2;
         this.tabControlEX2.UseVisualStyles = false;
         // 
         // tabPageEX3
         // 
         this.tabPageEX3.Controls.Add(this.dataGridView1);
         this.tabPageEX3.Location = new System.Drawing.Point(4, 25);
         this.tabPageEX3.Name = "tabPageEX3";
         this.tabPageEX3.Size = new System.Drawing.Size(874, 410);
         this.tabPageEX3.TabIndex = 0;
         this.tabPageEX3.Text = "tabPageEX3";
         // 
         // dataGridView1
         // 
         this.dataGridView1.AllowUserToAddRows = false;
         this.dataGridView1.AllowUserToDeleteRows = false;
         this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
         this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dataGridView1.Location = new System.Drawing.Point(0, 0);
         this.dataGridView1.MultiSelect = false;
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.ReadOnly = true;
         this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
         this.dataGridView1.RowHeadersVisible = false;
         this.dataGridView1.RowTemplate.Height = 16;
         this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dataGridView1.Size = new System.Drawing.Size(874, 410);
         this.dataGridView1.TabIndex = 3;
         // 
         // dataGridViewTextBoxColumn1
         // 
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
         this.dataGridViewTextBoxColumn1.HeaderText = "Address";
         this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
         this.dataGridViewTextBoxColumn1.ReadOnly = true;
         this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
         this.dataGridViewTextBoxColumn1.Width = 65;
         // 
         // dataGridViewTextBoxColumn2
         // 
         dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
         this.dataGridViewTextBoxColumn2.HeaderText = "Name";
         this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
         this.dataGridViewTextBoxColumn2.ReadOnly = true;
         this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
         this.dataGridViewTextBoxColumn2.Width = 175;
         // 
         // dataGridViewTextBoxColumn3
         // 
         dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle4.Font = new System.Drawing.Font("細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
         dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle4;
         this.dataGridViewTextBoxColumn3.HeaderText = "Value";
         this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
         this.dataGridViewTextBoxColumn3.ReadOnly = true;
         this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
         this.dataGridViewTextBoxColumn3.Width = 140;
         // 
         // dataGridViewTextBoxColumn4
         // 
         dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
         this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle5;
         this.dataGridViewTextBoxColumn4.HeaderText = "Hex";
         this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
         this.dataGridViewTextBoxColumn4.ReadOnly = true;
         this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
         this.dataGridViewTextBoxColumn4.Width = 50;
         // 
         // dataGridViewTextBoxColumn5
         // 
         this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle6;
         this.dataGridViewTextBoxColumn5.HeaderText = "Comment";
         this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
         this.dataGridViewTextBoxColumn5.ReadOnly = true;
         this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
         // 
         // refreshTimer
         // 
         this.refreshTimer.Interval = 500;
         this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
         // 
         // enableDetailsCheckBox
         // 
         this.enableDetailsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.enableDetailsCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
         this.enableDetailsCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.enableDetailsCheckBox.Location = new System.Drawing.Point(23, 17);
         this.enableDetailsCheckBox.Name = "enableDetailsCheckBox";
         this.enableDetailsCheckBox.Size = new System.Drawing.Size(108, 24);
         this.enableDetailsCheckBox.TabIndex = 5;
         this.enableDetailsCheckBox.Text = "Details";
         this.enableDetailsCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.enableDetailsCheckBox.UseVisualStyleBackColor = true;
         this.enableDetailsCheckBox.CheckedChanged += new System.EventHandler(this.enableDetailsCheckBox_CheckedChanged);
         // 
         // findWhatButton
         // 
         this.findWhatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.findWhatButton.Location = new System.Drawing.Point(128, 17);
         this.findWhatButton.Name = "findWhatButton";
         this.findWhatButton.Size = new System.Drawing.Size(75, 22);
         this.findWhatButton.TabIndex = 7;
         this.findWhatButton.Text = "Find";
         this.findWhatButton.UseVisualStyleBackColor = true;
         this.findWhatButton.Click += new System.EventHandler(this.findWhatButton_Click);
         // 
         // findWhatTextBox
         // 
         this.findWhatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.findWhatTextBox.Location = new System.Drawing.Point(22, 17);
         this.findWhatTextBox.Name = "findWhatTextBox";
         this.findWhatTextBox.Size = new System.Drawing.Size(100, 22);
         this.findWhatTextBox.TabIndex = 8;
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.groupBox1.Controls.Add(this.findWhatButton);
         this.groupBox1.Controls.Add(this.findWhatTextBox);
         this.groupBox1.Location = new System.Drawing.Point(7, 500);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(226, 49);
         this.groupBox1.TabIndex = 10;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Find What";
         // 
         // groupBox2
         // 
         this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.groupBox2.Controls.Add(this.enableDetailsCheckBox);
         this.groupBox2.Location = new System.Drawing.Point(239, 500);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(154, 49);
         this.groupBox2.TabIndex = 11;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Show Details";
         // 
         // PLCMonitorForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
         this.ClientSize = new System.Drawing.Size(904, 554);
         this.ControlBox = false;
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.level1TabControlEX);
         this.Controls.Add(this.exitButton);
         this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.Name = "PLCMonitorForm";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "PLC Monitor Form";
         this.VisibleChanged += new System.EventHandler(this.PLCMonitorForm_VisibleChanged);
         this.level1TabControlEX.ResumeLayout(false);
         this.tabPageEX1.ResumeLayout(false);
         this.tabControlEX2.ResumeLayout(false);
         this.tabPageEX3.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button exitButton;
      private Dotnetrix.Controls.TabControlEX level1TabControlEX;
      private Dotnetrix.Controls.TabPageEX tabPageEX1;
      private Dotnetrix.Controls.TabControlEX tabControlEX2;
      private Dotnetrix.Controls.TabPageEX tabPageEX3;
      private System.Windows.Forms.DataGridView dataGridView1;
      private System.Windows.Forms.Timer refreshTimer;
      private System.Windows.Forms.CheckBox enableDetailsCheckBox;
      private System.Windows.Forms.Button findWhatButton;
      private System.Windows.Forms.TextBox findWhatTextBox;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
      private System.Windows.Forms.GroupBox groupBox2;
   }
}