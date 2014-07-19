namespace Datalog
{
    partial class DIOMonitorUnitControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DOMonitorUnitControl = new Datalog.CCIOMonitorUnitControl();
            this.DIMonitorUnitControl = new Datalog.CCIOMonitorUnitControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "DI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "DO";
            // 
            // timer1
            // 
            this.timer1.Enabled = false;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DOMonitorUnitControl
            // 
            this.DOMonitorUnitControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.DOMonitorUnitControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DOMonitorUnitControl.Location = new System.Drawing.Point(11, 415);
            this.DOMonitorUnitControl.Name = "DOMonitorUnitControl";
            this.DOMonitorUnitControl.Size = new System.Drawing.Size(1093, 245);
            this.DOMonitorUnitControl.TabIndex = 4;
            // 
            // DIMonitorUnitControl
            // 
            this.DIMonitorUnitControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.DIMonitorUnitControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DIMonitorUnitControl.Location = new System.Drawing.Point(11, 42);
            this.DIMonitorUnitControl.Name = "DIMonitorUnitControl";
            this.DIMonitorUnitControl.Size = new System.Drawing.Size(1093, 245);
            this.DIMonitorUnitControl.TabIndex = 0;
            // 
            // DIOMonitorUnitControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DOMonitorUnitControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DIMonitorUnitControl);
            this.Name = "DIOMonitorUnitControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCIOMonitorUnitControl DIMonitorUnitControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CCIOMonitorUnitControl DOMonitorUnitControl;
        private System.Windows.Forms.Timer timer1;



    }
}
