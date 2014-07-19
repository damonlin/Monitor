namespace Monitor
{
   partial class SignalChartUnitControl
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
         this.signalLabel = new System.Windows.Forms.Label();
         this.titleLabel = new System.Windows.Forms.Label();
         this.updateSignalTimer = new System.Windows.Forms.Timer(this.components);
         this.SuspendLayout();
         // 
         // signalLabel
         // 
         this.signalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.signalLabel.Location = new System.Drawing.Point(6, 25);
         this.signalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.signalLabel.Name = "signalLabel";
         this.signalLabel.Size = new System.Drawing.Size(128, 20);
         this.signalLabel.TabIndex = 2;
         this.signalLabel.Text = "Recv Verify Sensor";
         this.signalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.signalLabel.Visible = false;
         // 
         // titleLabel
         // 
         this.titleLabel.AutoSize = true;
         this.titleLabel.BackColor = System.Drawing.Color.Transparent;
         this.titleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.titleLabel.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.titleLabel.Location = new System.Drawing.Point(4, 6);
         this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.titleLabel.Name = "titleLabel";
         this.titleLabel.Size = new System.Drawing.Size(144, 14);
         this.titleLabel.TabIndex = 3;
         this.titleLabel.Text = "Upstream Equipment";
         this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.titleLabel.Visible = false;
         // 
         // updateSignalTimer
         // 
         this.updateSignalTimer.Enabled = true;
         this.updateSignalTimer.Interval = 250;
         this.updateSignalTimer.Tick += new System.EventHandler(this.updateSignalTimer_Tick);
         // 
         // SignalChartUnitControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.Controls.Add(this.titleLabel);
         this.Controls.Add(this.signalLabel);
         this.DoubleBuffered = true;
         this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
         this.Name = "SignalChartUnitControl";
         this.Size = new System.Drawing.Size(870, 410);
         this.Paint += new System.Windows.Forms.PaintEventHandler(this.SignalChartUnitControl_Paint);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label signalLabel;
      private System.Windows.Forms.Label titleLabel;
      private System.Windows.Forms.Timer updateSignalTimer;
   }
}
