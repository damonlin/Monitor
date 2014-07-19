namespace Monitor
{
   partial class LinkSignalMonitorForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinkSignalMonitorForm));
			this.exitButton = new System.Windows.Forms.Button();
			this.level1TabControlEX = new Dotnetrix.Controls.TabControlEX();
			this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
			this.tabControlEX2 = new Dotnetrix.Controls.TabControlEX();
			this.tabPageEX3 = new Dotnetrix.Controls.TabPageEX();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPageEX2 = new Dotnetrix.Controls.TabPageEX();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.tabPageEX4 = new Dotnetrix.Controls.TabPageEX();
			this.signalChartUnitControl1 = new SignalChartUnitControl();
			this.level1TabControlEX.SuspendLayout();
			this.tabPageEX1.SuspendLayout();
			this.tabControlEX2.SuspendLayout();
			this.tabPageEX3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.tabPageEX2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel3.SuspendLayout();
			this.tabPageEX4.SuspendLayout();
			this.SuspendLayout();
			// 
			// exitButton
			// 
			this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitButton.Location = new System.Drawing.Point(809, 502);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(90, 45);
			this.exitButton.TabIndex = 4;
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
			this.level1TabControlEX.TabIndex = 5;
			this.level1TabControlEX.UseVisualStyles = false;
			// 
			// tabPageEX1
			// 
			this.tabPageEX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
			this.tabPageEX1.Controls.Add(this.tabControlEX2);
			this.tabPageEX1.Location = new System.Drawing.Point(4, 44);
			this.tabPageEX1.Name = "tabPageEX1";
			this.tabPageEX1.Size = new System.Drawing.Size(882, 439);
			this.tabPageEX1.TabIndex = 0;
			this.tabPageEX1.Text = "IO Handshake";
			// 
			// tabControlEX2
			// 
			this.tabControlEX2.Appearance = Dotnetrix.Controls.TabAppearanceEX.FlatButton;
			this.tabControlEX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
			this.tabControlEX2.Controls.Add(this.tabPageEX3);
			this.tabControlEX2.Controls.Add(this.tabPageEX4);
			this.tabControlEX2.Controls.Add(this.tabPageEX2);
			this.tabControlEX2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlEX2.Location = new System.Drawing.Point(0, 0);
			this.tabControlEX2.Name = "tabControlEX2";
			this.tabControlEX2.SelectedIndex = 2;
			this.tabControlEX2.SelectedTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
			this.tabControlEX2.SelectedTabFontStyle = System.Drawing.FontStyle.Bold;
			this.tabControlEX2.Size = new System.Drawing.Size(882, 439);
			this.tabControlEX2.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
			this.tabControlEX2.TabIndex = 7;
			this.tabControlEX2.UseVisualStyles = false;
			// 
			// tabPageEX3
			// 
			this.tabPageEX3.Controls.Add(this.groupBox2);
			this.tabPageEX3.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX3.Name = "tabPageEX3";
			this.tabPageEX3.Size = new System.Drawing.Size(874, 410);
			this.tabPageEX3.TabIndex = 0;
			this.tabPageEX3.Text = "Signals for Loading";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridView2);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox2.Location = new System.Drawing.Point(3, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(449, 433);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "groupBox2";
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AllowUserToResizeColumns = false;
			this.dataGridView2.AllowUserToResizeRows = false;
			this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
			this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView2.Location = new System.Drawing.Point(3, 18);
			this.dataGridView2.MultiSelect = false;
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridView2.RowHeadersVisible = false;
			this.dataGridView2.RowTemplate.Height = 16;
			this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView2.Size = new System.Drawing.Size(443, 412);
			this.dataGridView2.TabIndex = 3;
			// 
			// dataGridViewTextBoxColumn5
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewTextBoxColumn5.HeaderText = "No";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn5.Width = 30;
			// 
			// dataGridViewTextBoxColumn6
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewTextBoxColumn6.HeaderText = "Address";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn6.Width = 65;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewTextBoxColumn7.HeaderText = "Signal Name";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// dataGridViewTextBoxColumn8
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewTextBoxColumn8.HeaderText = "Value";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn8.Width = 50;
			// 
			// tabPageEX2
			// 
			this.tabPageEX2.Controls.Add(this.pictureBox1);
			this.tabPageEX2.Controls.Add(this.panel3);
			this.tabPageEX2.Controls.Add(this.button1);
			this.tabPageEX2.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX2.Name = "tabPageEX2";
			this.tabPageEX2.Size = new System.Drawing.Size(874, 410);
			this.tabPageEX2.TabIndex = 1;
			this.tabPageEX2.Text = "Signals for Unloading";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(237, 201);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(606, 135);
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.radioButton1);
			this.panel3.Location = new System.Drawing.Point(44, 50);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(379, 125);
			this.panel3.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(119, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 39);
			this.label2.TabIndex = 12;
			this.label2.Text = "To Downstream";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Location = new System.Drawing.Point(53, 47);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(67, 39);
			this.panel4.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(62, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 14);
			this.label1.TabIndex = 8;
			this.label1.Text = "Upstream Equipment";
			// 
			// radioButton1
			// 
			this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
			this.radioButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.radioButton1.FlatAppearance.BorderSize = 0;
			this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radioButton1.Location = new System.Drawing.Point(121, 30);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(217, 70);
			this.radioButton1.TabIndex = 9;
			this.radioButton1.TabStop = true;
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(164, 307);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(247, 60);
			this.button1.TabIndex = 6;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// tabPageEX4
			// 
			this.tabPageEX4.Controls.Add(this.signalChartUnitControl1);
			this.tabPageEX4.Location = new System.Drawing.Point(4, 25);
			this.tabPageEX4.Name = "tabPageEX4";
			this.tabPageEX4.Size = new System.Drawing.Size(874, 410);
			this.tabPageEX4.TabIndex = 2;
			this.tabPageEX4.Text = "tabPageEX4";
			// 
			// signalChartUnitControl1
			// 
			this.signalChartUnitControl1.BackColor = System.Drawing.Color.White;
			this.signalChartUnitControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.signalChartUnitControl1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.signalChartUnitControl1.Location = new System.Drawing.Point(2, 0);
			this.signalChartUnitControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.signalChartUnitControl1.Name = "signalChartUnitControl1";
			this.signalChartUnitControl1.Size = new System.Drawing.Size(870, 410);
			this.signalChartUnitControl1.TabIndex = 0;
			// 
			// LinkSignalMonitorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
			this.ClientSize = new System.Drawing.Size(904, 554);
			this.ControlBox = false;
			this.Controls.Add(this.level1TabControlEX);
			this.Controls.Add(this.exitButton);
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "LinkSignalMonitorForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Link Signal Monitor Form";
			this.level1TabControlEX.ResumeLayout(false);
			this.tabPageEX1.ResumeLayout(false);
			this.tabControlEX2.ResumeLayout(false);
			this.tabPageEX3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.tabPageEX2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.tabPageEX4.ResumeLayout(false);
			this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button exitButton;
      private Dotnetrix.Controls.TabControlEX level1TabControlEX;
      private Dotnetrix.Controls.TabPageEX tabPageEX1;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.DataGridView dataGridView2;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
      private Dotnetrix.Controls.TabControlEX tabControlEX2;
      private Dotnetrix.Controls.TabPageEX tabPageEX3;
      private Dotnetrix.Controls.TabPageEX tabPageEX2;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.RadioButton radioButton1;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Panel panel3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Panel panel4;
      private Dotnetrix.Controls.TabPageEX tabPageEX4;
      private SignalChartUnitControl signalChartUnitControl1;
   }
}