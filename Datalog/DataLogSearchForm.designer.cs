namespace Datalog
{
   partial class DataLogSearchForm
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
          this.searchLogListBox = new System.Windows.Forms.ListBox();
          this.closeButton = new System.Windows.Forms.Button();
          this.SuspendLayout();
          // 
          // searchLogListBox
          // 
          this.searchLogListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.searchLogListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          this.searchLogListBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.searchLogListBox.FormattingEnabled = true;
          this.searchLogListBox.HorizontalScrollbar = true;
          this.searchLogListBox.ItemHeight = 15;
          this.searchLogListBox.Location = new System.Drawing.Point(12, 12);
          this.searchLogListBox.Name = "searchLogListBox";
          this.searchLogListBox.Size = new System.Drawing.Size(377, 227);
          this.searchLogListBox.TabIndex = 53;
          // 
          // closeButton
          // 
          this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
          this.closeButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.closeButton.Location = new System.Drawing.Point(395, 12);
          this.closeButton.Name = "closeButton";
          this.closeButton.Size = new System.Drawing.Size(90, 30);
          this.closeButton.TabIndex = 54;
          this.closeButton.Text = "Close";
          this.closeButton.UseVisualStyleBackColor = true;
          this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
          // 
          // DataLogSearchForm
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.BackColor = System.Drawing.SystemColors.ControlLight;
          this.ClientSize = new System.Drawing.Size(498, 247);
          this.Controls.Add(this.closeButton);
          this.Controls.Add(this.searchLogListBox);
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
          this.MaximizeBox = false;
          this.MinimizeBox = false;
          this.Name = "DataLogSearchForm";
          this.ShowInTaskbar = false;
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
          this.Text = "Data Log Search Form";
          this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DataLogSearchForm_FormClosed);
          this.ResumeLayout(false);

      }

      #endregion

       private System.Windows.Forms.Button closeButton;
       public System.Windows.Forms.ListBox searchLogListBox;
   }
}