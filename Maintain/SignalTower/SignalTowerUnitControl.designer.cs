namespace Maintain
{
   partial class SignalTowerUnitControl
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
         this.redPanel = new System.Windows.Forms.Panel();
         this.yellowPanel = new System.Windows.Forms.Panel();
         this.greenPanel = new System.Windows.Forms.Panel();
         this.bluePanel = new System.Windows.Forms.Panel();
         this.flashTimer = new System.Windows.Forms.Timer(this.components);
         this.SuspendLayout();
         // 
         // redPanel
         // 
         this.redPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.redPanel.BackColor = System.Drawing.Color.Red;
         this.redPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.redPanel.Location = new System.Drawing.Point(0, 0);
         this.redPanel.Name = "redPanel";
         this.redPanel.Size = new System.Drawing.Size(18, 12);
         this.redPanel.TabIndex = 0;
         // 
         // yellowPanel
         // 
         this.yellowPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.yellowPanel.BackColor = System.Drawing.Color.Yellow;
         this.yellowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.yellowPanel.Location = new System.Drawing.Point(0, 11);
         this.yellowPanel.Name = "yellowPanel";
         this.yellowPanel.Size = new System.Drawing.Size(18, 12);
         this.yellowPanel.TabIndex = 1;
         // 
         // greenPanel
         // 
         this.greenPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.greenPanel.BackColor = System.Drawing.Color.Lime;
         this.greenPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.greenPanel.Location = new System.Drawing.Point(0, 22);
         this.greenPanel.Name = "greenPanel";
         this.greenPanel.Size = new System.Drawing.Size(18, 12);
         this.greenPanel.TabIndex = 2;
         // 
         // bluePanel
         // 
         this.bluePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
         this.bluePanel.BackColor = System.Drawing.Color.Blue;
         this.bluePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.bluePanel.Location = new System.Drawing.Point(0, 33);
         this.bluePanel.Name = "bluePanel";
         this.bluePanel.Size = new System.Drawing.Size(18, 12);
         this.bluePanel.TabIndex = 3;
         // 
         // flashTimer
         // 
         this.flashTimer.Interval = 500;
         this.flashTimer.Tick += new System.EventHandler(this.flashTimer_Tick);
         // 
         // SignalTowerUnitControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Black;
         this.Controls.Add(this.bluePanel);
         this.Controls.Add(this.yellowPanel);
         this.Controls.Add(this.redPanel);
         this.Controls.Add(this.greenPanel);
         this.Name = "SignalTowerUnitControl";
         this.Size = new System.Drawing.Size(18, 45);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel redPanel;
      private System.Windows.Forms.Panel yellowPanel;
      private System.Windows.Forms.Panel greenPanel;
      private System.Windows.Forms.Panel bluePanel;
      private System.Windows.Forms.Timer flashTimer;
   }
}
