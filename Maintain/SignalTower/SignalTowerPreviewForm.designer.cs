namespace Maintain
{
   partial class SignalTowerPreviewForm
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
         this.signalTowerUnitControl = new SignalTowerUnitControl();
         this.SuspendLayout();
         // 
         // signalTowerUnitControl
         // 
         this.signalTowerUnitControl.BackColor = System.Drawing.Color.Black;
         this.signalTowerUnitControl.Location = new System.Drawing.Point(12, 12);
         this.signalTowerUnitControl.Name = "signalTowerUnitControl";
         this.signalTowerUnitControl.Size = new System.Drawing.Size(18, 45);
         this.signalTowerUnitControl.TabIndex = 1;
         // 
         // SignalTowerPreviewForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(115, 163);
         this.Controls.Add(this.signalTowerUnitControl);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "SignalTowerPreviewForm";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Preview";
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignalTowerPreviewForm_FormClosed);
         this.ResumeLayout(false);

      }

      #endregion

      private SignalTowerUnitControl signalTowerUnitControl;
   }
}