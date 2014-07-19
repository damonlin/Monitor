namespace Maintain
{
   partial class SignalTowerPanelControl
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
         this.dataGridView = new System.Windows.Forms.DataGridView();
         this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.RedLight = new System.Windows.Forms.DataGridViewComboBoxColumn();
         this.YellowLight = new System.Windows.Forms.DataGridViewComboBoxColumn();
         this.GreenLight = new System.Windows.Forms.DataGridViewComboBoxColumn();
         this.BlueLight = new System.Windows.Forms.DataGridViewComboBoxColumn();
         this.Buzzer = new System.Windows.Forms.DataGridViewComboBoxColumn();
         this.Test = new System.Windows.Forms.DataGridViewButtonColumn();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
         this.SuspendLayout();
         // 
         // dataGridView
         // 
         this.dataGridView.AllowUserToAddRows = false;
         this.dataGridView.AllowUserToDeleteRows = false;
         this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         this.dataGridView.ColumnHeadersHeight = 40;
         this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
         this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Status,
            this.Description,
            this.RedLight,
            this.YellowLight,
            this.GreenLight,
            this.BlueLight,
            this.Buzzer,
            this.Test});
         dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
         dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
         dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.dataGridView.DefaultCellStyle = dataGridViewCellStyle6;
         this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
         this.dataGridView.Location = new System.Drawing.Point(0, 0);
         this.dataGridView.Name = "dataGridView";
         dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle7.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
         dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
         this.dataGridView.RowHeadersVisible = false;
         this.dataGridView.RowTemplate.Height = 24;
         this.dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.dataGridView.Size = new System.Drawing.Size(1109, 843);
         this.dataGridView.TabIndex = 1;
         this.dataGridView.RowHeightChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_RowHeightChanged);
         this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
         this.dataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_DataError);
         this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
         // 
         // Index
         // 
         dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
         dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
         this.Index.DefaultCellStyle = dataGridViewCellStyle2;
         this.Index.Frozen = true;
         this.Index.HeaderText = "#";
         this.Index.MinimumWidth = 25;
         this.Index.Name = "Index";
         this.Index.ReadOnly = true;
         this.Index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.Index.Width = 25;
         // 
         // Status
         // 
         dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gold;
         dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.Status.DefaultCellStyle = dataGridViewCellStyle3;
         this.Status.Frozen = true;
         this.Status.HeaderText = "Status";
         this.Status.Name = "Status";
         this.Status.ReadOnly = true;
         this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
         this.Status.Width = 150;
         // 
         // Description
         // 
         this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.Description.DefaultCellStyle = dataGridViewCellStyle4;
         this.Description.HeaderText = "Description";
         this.Description.Name = "Description";
         this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
         // 
         // RedLight
         // 
         this.RedLight.HeaderText = "Red Light";
         this.RedLight.Items.AddRange(new object[] {
            "On",
            "Off",
            "Flash(500ms)",
            "Flash(1000ms)",
            "Flash(1500ms)",
            "Flash(2000ms)",
            "Flash(2500ms)",
            "Flash(3000ms)",
            "Flash(3500ms)",
            "Flash(4000ms)",
            "Flash(4500ms)",
            "Flash(5000ms)"});
         this.RedLight.Name = "RedLight";
         this.RedLight.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.RedLight.Width = 110;
         // 
         // YellowLight
         // 
         this.YellowLight.HeaderText = "Yellow Light";
         this.YellowLight.Items.AddRange(new object[] {
            "On",
            "Off",
            "Flash(500ms)",
            "Flash(1000ms)",
            "Flash(1500ms)",
            "Flash(2000ms)",
            "Flash(2500ms)",
            "Flash(3000ms)",
            "Flash(3500ms)",
            "Flash(4000ms)",
            "Flash(4500ms)",
            "Flash(5000ms)"});
         this.YellowLight.Name = "YellowLight";
         this.YellowLight.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.YellowLight.Width = 110;
         // 
         // GreenLight
         // 
         this.GreenLight.HeaderText = "Green Light";
         this.GreenLight.Items.AddRange(new object[] {
            "On",
            "Off",
            "Flash(500ms)",
            "Flash(1000ms)",
            "Flash(1500ms)",
            "Flash(2000ms)",
            "Flash(2500ms)",
            "Flash(3000ms)",
            "Flash(3500ms)",
            "Flash(4000ms)",
            "Flash(4500ms)",
            "Flash(5000ms)"});
         this.GreenLight.Name = "GreenLight";
         this.GreenLight.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.GreenLight.Width = 110;
         // 
         // BlueLight
         // 
         this.BlueLight.HeaderText = "Blue Light";
         this.BlueLight.Items.AddRange(new object[] {
            "On",
            "Off",
            "Flash(500ms)",
            "Flash(1000ms)",
            "Flash(1500ms)",
            "Flash(2000ms)",
            "Flash(2500ms)",
            "Flash(3000ms)",
            "Flash(3500ms)",
            "Flash(4000ms)",
            "Flash(4500ms)",
            "Flash(5000ms)"});
         this.BlueLight.Name = "BlueLight";
         this.BlueLight.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.BlueLight.Width = 110;
         // 
         // Buzzer
         // 
         this.Buzzer.HeaderText = "Buzzer";
         this.Buzzer.Items.AddRange(new object[] {
            "No sound",
            "Long beep",
            "Short interval beep"});
         this.Buzzer.Name = "Buzzer";
         this.Buzzer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.Buzzer.Width = 135;
         // 
         // Test
         // 
         dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         this.Test.DefaultCellStyle = dataGridViewCellStyle5;
         this.Test.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.Test.HeaderText = "Test";
         this.Test.Name = "Test";
         this.Test.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.Test.Width = 75;
         // 
         // SignalTowerPanelControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.dataGridView);
         this.Name = "SignalTowerPanelControl";
         this.Size = new System.Drawing.Size(1109, 843);
         this.Load += new System.EventHandler(this.SignalTowerPanelControl_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataGridView dataGridView;
      private System.Windows.Forms.DataGridViewTextBoxColumn Index;
      private System.Windows.Forms.DataGridViewTextBoxColumn Status;
      private System.Windows.Forms.DataGridViewTextBoxColumn Description;
      private System.Windows.Forms.DataGridViewComboBoxColumn RedLight;
      private System.Windows.Forms.DataGridViewComboBoxColumn YellowLight;
      private System.Windows.Forms.DataGridViewComboBoxColumn GreenLight;
      private System.Windows.Forms.DataGridViewComboBoxColumn BlueLight;
      private System.Windows.Forms.DataGridViewComboBoxColumn Buzzer;
      private System.Windows.Forms.DataGridViewButtonColumn Test;
   }
}
