namespace Monitor
{
   partial class IOMonitorUnitControl
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
         this.components = new System.ComponentModel.Container();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
         this.sampleDataGridView = new System.Windows.Forms.DataGridView();
         this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Status = new System.Windows.Forms.DataGridViewButtonColumn();
         this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.tabControlEX = new Dotnetrix.Controls.TabControlEX();
         this.sampleTabPage = new Dotnetrix.Controls.TabPageEX();
         this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
         this.timer1 = new System.Windows.Forms.Timer(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.sampleDataGridView)).BeginInit();
         this.tabControlEX.SuspendLayout();
         this.sampleTabPage.SuspendLayout();
         this.SuspendLayout();
         // 
         // sampleDataGridView
         // 
         this.sampleDataGridView.AllowUserToAddRows = false;
         this.sampleDataGridView.AllowUserToDeleteRows = false;
         this.sampleDataGridView.AllowUserToResizeColumns = false;
         this.sampleDataGridView.AllowUserToResizeRows = false;
         dataGridViewCellStyle1.NullValue = null;
         this.sampleDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
         this.sampleDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
         dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.sampleDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
         this.sampleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.sampleDataGridView.ColumnHeadersVisible = false;
         this.sampleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Status,
            this.Description});
         this.sampleDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
         this.sampleDataGridView.Enabled = false;
         this.sampleDataGridView.Location = new System.Drawing.Point(0, 0);
         this.sampleDataGridView.MultiSelect = false;
         this.sampleDataGridView.Name = "sampleDataGridView";
         this.sampleDataGridView.ReadOnly = true;
         dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle3.Format = "N0";
         dataGridViewCellStyle3.NullValue = null;
         dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.sampleDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
         this.sampleDataGridView.RowHeadersVisible = false;
         this.sampleDataGridView.RowHeadersWidth = 25;
         this.sampleDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
         dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder;
         this.sampleDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
         this.sampleDataGridView.RowTemplate.Height = 24;
         this.sampleDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
         this.sampleDataGridView.Size = new System.Drawing.Size(906, 154);
         this.sampleDataGridView.TabIndex = 15;
         // 
         // Column1
         // 
         this.Column1.Frozen = true;
         this.Column1.HeaderText = "Idx1";
         this.Column1.Name = "Column1";
         this.Column1.ReadOnly = true;
         this.Column1.Width = 20;
         // 
         // Status
         // 
         this.Status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.Status.Frozen = true;
         this.Status.HeaderText = "Status";
         this.Status.Name = "Status";
         this.Status.ReadOnly = true;
         this.Status.Width = 25;
         // 
         // Description
         // 
         this.Description.FillWeight = 176F;
         this.Description.Frozen = true;
         this.Description.HeaderText = "Description";
         this.Description.Name = "Description";
         this.Description.ReadOnly = true;
         this.Description.Width = 150;
         // 
         // tabControlEX
         // 
         this.tabControlEX.Appearance = Dotnetrix.Controls.TabAppearanceEX.FlatButton;
         this.tabControlEX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
         this.tabControlEX.Controls.Add(this.sampleTabPage);
         this.tabControlEX.Controls.Add(this.tabPageEX1);
         this.tabControlEX.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tabControlEX.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tabControlEX.Location = new System.Drawing.Point(0, 0);
         this.tabControlEX.Name = "tabControlEX";
         this.tabControlEX.SelectedIndex = 0;
         this.tabControlEX.SelectedTabFontStyle = System.Drawing.FontStyle.Bold;
         this.tabControlEX.Size = new System.Drawing.Size(914, 183);
         this.tabControlEX.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
         this.tabControlEX.TabIndex = 1;
         this.tabControlEX.UseVisualStyles = false;
         // 
         // sampleTabPage
         // 
         this.sampleTabPage.Controls.Add(this.sampleDataGridView);
         this.sampleTabPage.Location = new System.Drawing.Point(4, 25);
         this.sampleTabPage.Name = "sampleTabPage";
         this.sampleTabPage.Size = new System.Drawing.Size(906, 154);
         this.sampleTabPage.TabIndex = 0;
         this.sampleTabPage.Text = "tabPageEX1";
         // 
         // tabPageEX1
         // 
         this.tabPageEX1.Location = new System.Drawing.Point(4, 25);
         this.tabPageEX1.Name = "tabPageEX1";
         this.tabPageEX1.Size = new System.Drawing.Size(906, 154);
         this.tabPageEX1.TabIndex = 1;
         this.tabPageEX1.Text = "tabPageEX1";
         // 
         // timer1
         // 
         this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
         // 
         // IOMonitorUnitControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
         this.Controls.Add(this.tabControlEX);
         this.Name = "IOMonitorUnitControl";
         this.Size = new System.Drawing.Size(914, 183);
         ((System.ComponentModel.ISupportInitialize)(this.sampleDataGridView)).EndInit();
         this.tabControlEX.ResumeLayout(false);
         this.sampleTabPage.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataGridView sampleDataGridView;
      private Dotnetrix.Controls.TabControlEX tabControlEX;
      private Dotnetrix.Controls.TabPageEX sampleTabPage;
      private Dotnetrix.Controls.TabPageEX tabPageEX1;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
      private System.Windows.Forms.DataGridViewButtonColumn Status;
      private System.Windows.Forms.DataGridViewTextBoxColumn Description;
      private System.Windows.Forms.Timer timer1;

   }
}
