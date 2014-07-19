namespace Monitor
{
   partial class IOMonitorForm
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
         this.exitButton = new System.Windows.Forms.Button();
         this.label5 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.diMonitorUnitControl = new IOMonitorUnitControl();
         this.panel2 = new System.Windows.Forms.Panel();
         this.doMonitorUnitControl = new IOMonitorUnitControl();
         this.panel1.SuspendLayout();
         this.panel2.SuspendLayout();
         this.SuspendLayout();
         // 
         // exitButton
         // 
         this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.exitButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.exitButton.Location = new System.Drawing.Point(835, 428);
         this.exitButton.Name = "exitButton";
         this.exitButton.Size = new System.Drawing.Size(90, 45);
         this.exitButton.TabIndex = 2;
         this.exitButton.Text = "Close";
         this.exitButton.UseVisualStyleBackColor = true;
         this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
         // 
         // label5
         // 
         this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(195)))), ((int)(((byte)(222)))));
         this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this.label5.Location = new System.Drawing.Point(7, 9);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(918, 21);
         this.label5.TabIndex = 28;
         this.label5.Text = "DI";
         this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // label1
         // 
         this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(195)))), ((int)(((byte)(222)))));
         this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this.label1.Location = new System.Drawing.Point(7, 215);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(918, 21);
         this.label1.TabIndex = 30;
         this.label1.Text = "DO";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // panel1
         // 
         this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel1.Controls.Add(this.diMonitorUnitControl);
         this.panel1.Location = new System.Drawing.Point(7, 29);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(918, 187);
         this.panel1.TabIndex = 31;
         // 
         // diMonitorUnitControl
         // 
         this.diMonitorUnitControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
         this.diMonitorUnitControl.Location = new System.Drawing.Point(1, 1);
         this.diMonitorUnitControl.Name = "diMonitorUnitControl";
         this.diMonitorUnitControl.Size = new System.Drawing.Size(914, 183);
         this.diMonitorUnitControl.TabIndex = 0;
         // 
         // panel2
         // 
         this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel2.Controls.Add(this.doMonitorUnitControl);
         this.panel2.Location = new System.Drawing.Point(7, 235);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(918, 187);
         this.panel2.TabIndex = 32;
         // 
         // doMonitorUnitControl
         // 
         this.doMonitorUnitControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
         this.doMonitorUnitControl.Location = new System.Drawing.Point(1, 1);
         this.doMonitorUnitControl.Name = "doMonitorUnitControl";
         this.doMonitorUnitControl.Size = new System.Drawing.Size(914, 183);
         this.doMonitorUnitControl.TabIndex = 0;
         // 
         // IOMonitorForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
         this.ClientSize = new System.Drawing.Size(933, 479);
         this.ControlBox = false;
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.exitButton);
         this.DoubleBuffered = true;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "IOMonitorForm";
         this.ShowInTaskbar = false;
         this.Text = "DIO Monitor";
         this.panel1.ResumeLayout(false);
         this.panel2.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button exitButton;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Panel panel2;
      private IOMonitorUnitControl diMonitorUnitControl;
      private IOMonitorUnitControl doMonitorUnitControl;
   }
}