namespace ContrelModule
{
    partial class LaserParaAdjust
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.m_radioNowSetting = new System.Windows.Forms.RadioButton();
            this.m_radioTeachSetting = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.m_txbLaserPower = new System.Windows.Forms.TextBox();
            this.m_txbPolarize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.m_txbZOffset = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_txbAcc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_Speed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.m_txbDec = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.m_btnHighSpeed = new System.Windows.Forms.Button();
            this.m_chbFilterOn = new System.Windows.Forms.CheckBox();
            this.m_radioClockwise = new System.Windows.Forms.RadioButton();
            this.m_radioCounterclockwise = new System.Windows.Forms.RadioButton();
            this.m_btnMiddleSpeed = new System.Windows.Forms.Button();
            this.m_btnLowSpeed = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "雷射參數微調";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.m_radioTeachSetting);
            this.groupBox2.Controls.Add(this.m_radioNowSetting);
            this.groupBox2.Location = new System.Drawing.Point(6, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 63);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "參數設定使用";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.m_txbPolarize);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.m_txbLaserPower);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 79);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "雷射參數微調";
            // 
            // m_radioNowSetting
            // 
            this.m_radioNowSetting.Appearance = System.Windows.Forms.Appearance.Button;
            this.m_radioNowSetting.Location = new System.Drawing.Point(6, 21);
            this.m_radioNowSetting.Name = "m_radioNowSetting";
            this.m_radioNowSetting.Size = new System.Drawing.Size(109, 36);
            this.m_radioNowSetting.TabIndex = 2;
            this.m_radioNowSetting.TabStop = true;
            this.m_radioNowSetting.Text = "使用目前設定";
            this.m_radioNowSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_radioNowSetting.UseVisualStyleBackColor = true;
            // 
            // m_radioTeachSetting
            // 
            this.m_radioTeachSetting.Appearance = System.Windows.Forms.Appearance.Button;
            this.m_radioTeachSetting.Location = new System.Drawing.Point(121, 21);
            this.m_radioTeachSetting.Name = "m_radioTeachSetting";
            this.m_radioTeachSetting.Size = new System.Drawing.Size(109, 36);
            this.m_radioTeachSetting.TabIndex = 3;
            this.m_radioTeachSetting.TabStop = true;
            this.m_radioTeachSetting.Text = "使用教導設定";
            this.m_radioTeachSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_radioTeachSetting.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Laser Power：";
            // 
            // m_txbLaserPower
            // 
            this.m_txbLaserPower.Location = new System.Drawing.Point(104, 21);
            this.m_txbLaserPower.Name = "m_txbLaserPower";
            this.m_txbLaserPower.Size = new System.Drawing.Size(100, 22);
            this.m_txbLaserPower.TabIndex = 2;
            // 
            // m_txbPolarize
            // 
            this.m_txbPolarize.Location = new System.Drawing.Point(104, 49);
            this.m_txbPolarize.Name = "m_txbPolarize";
            this.m_txbPolarize.Size = new System.Drawing.Size(100, 22);
            this.m_txbPolarize.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Polarize：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.m_txbDec);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.m_Speed);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.m_txbAcc);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.m_txbZOffset);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(262, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(195, 148);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "速度微調";
            // 
            // m_txbZOffset
            // 
            this.m_txbZOffset.Location = new System.Drawing.Point(73, 21);
            this.m_txbZOffset.Name = "m_txbZOffset";
            this.m_txbZOffset.Size = new System.Drawing.Size(100, 22);
            this.m_txbZOffset.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Z Offset：";
            // 
            // m_txbAcc
            // 
            this.m_txbAcc.Location = new System.Drawing.Point(73, 49);
            this.m_txbAcc.Name = "m_txbAcc";
            this.m_txbAcc.Size = new System.Drawing.Size(100, 22);
            this.m_txbAcc.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "加速度：";
            // 
            // m_Speed
            // 
            this.m_Speed.Location = new System.Drawing.Point(73, 77);
            this.m_Speed.Name = "m_Speed";
            this.m_Speed.Size = new System.Drawing.Size(100, 22);
            this.m_Speed.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "速度：";
            // 
            // m_txbDec
            // 
            this.m_txbDec.Location = new System.Drawing.Point(73, 105);
            this.m_txbDec.Name = "m_txbDec";
            this.m_txbDec.Size = new System.Drawing.Size(100, 22);
            this.m_txbDec.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "減速度：";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.m_btnLowSpeed);
            this.groupBox5.Controls.Add(this.m_btnMiddleSpeed);
            this.groupBox5.Controls.Add(this.m_radioCounterclockwise);
            this.groupBox5.Controls.Add(this.m_radioClockwise);
            this.groupBox5.Controls.Add(this.m_chbFilterOn);
            this.groupBox5.Controls.Add(this.m_btnHighSpeed);
            this.groupBox5.Location = new System.Drawing.Point(6, 187);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(451, 64);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "偏光板角度微調";
            // 
            // m_btnHighSpeed
            // 
            this.m_btnHighSpeed.Location = new System.Drawing.Point(240, 21);
            this.m_btnHighSpeed.Name = "m_btnHighSpeed";
            this.m_btnHighSpeed.Size = new System.Drawing.Size(57, 36);
            this.m_btnHighSpeed.TabIndex = 0;
            this.m_btnHighSpeed.Text = "高速";
            this.m_btnHighSpeed.UseVisualStyleBackColor = true;
            // 
            // m_chbFilterOn
            // 
            this.m_chbFilterOn.Appearance = System.Windows.Forms.Appearance.Button;
            this.m_chbFilterOn.Location = new System.Drawing.Point(11, 22);
            this.m_chbFilterOn.Name = "m_chbFilterOn";
            this.m_chbFilterOn.Size = new System.Drawing.Size(104, 36);
            this.m_chbFilterOn.TabIndex = 1;
            this.m_chbFilterOn.Text = "偏光板伸出";
            this.m_chbFilterOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_chbFilterOn.UseVisualStyleBackColor = true;
            this.m_chbFilterOn.CheckedChanged += new System.EventHandler(this.m_chbFilterOn_CheckedChanged);
            // 
            // m_radioClockwise
            // 
            this.m_radioClockwise.AutoSize = true;
            this.m_radioClockwise.Location = new System.Drawing.Point(128, 32);
            this.m_radioClockwise.Name = "m_radioClockwise";
            this.m_radioClockwise.Size = new System.Drawing.Size(47, 16);
            this.m_radioClockwise.TabIndex = 2;
            this.m_radioClockwise.TabStop = true;
            this.m_radioClockwise.Text = "正轉";
            this.m_radioClockwise.UseVisualStyleBackColor = true;
            this.m_radioClockwise.CheckedChanged += new System.EventHandler(this.m_radioClockwise_CheckedChanged);
            // 
            // m_radioCounterclockwise
            // 
            this.m_radioCounterclockwise.AutoSize = true;
            this.m_radioCounterclockwise.Location = new System.Drawing.Point(181, 32);
            this.m_radioCounterclockwise.Name = "m_radioCounterclockwise";
            this.m_radioCounterclockwise.Size = new System.Drawing.Size(47, 16);
            this.m_radioCounterclockwise.TabIndex = 3;
            this.m_radioCounterclockwise.TabStop = true;
            this.m_radioCounterclockwise.Text = "反轉";
            this.m_radioCounterclockwise.UseVisualStyleBackColor = true;
            // 
            // m_btnMiddleSpeed
            // 
            this.m_btnMiddleSpeed.Location = new System.Drawing.Point(303, 22);
            this.m_btnMiddleSpeed.Name = "m_btnMiddleSpeed";
            this.m_btnMiddleSpeed.Size = new System.Drawing.Size(57, 36);
            this.m_btnMiddleSpeed.TabIndex = 4;
            this.m_btnMiddleSpeed.Text = "中速";
            this.m_btnMiddleSpeed.UseVisualStyleBackColor = true;
            this.m_btnMiddleSpeed.Click += new System.EventHandler(this.m_btnMiddleSpeed_Click);
            // 
            // m_btnLowSpeed
            // 
            this.m_btnLowSpeed.Location = new System.Drawing.Point(366, 22);
            this.m_btnLowSpeed.Name = "m_btnLowSpeed";
            this.m_btnLowSpeed.Size = new System.Drawing.Size(57, 36);
            this.m_btnLowSpeed.TabIndex = 5;
            this.m_btnLowSpeed.Text = "低速";
            this.m_btnLowSpeed.UseVisualStyleBackColor = true;
            this.m_btnLowSpeed.Click += new System.EventHandler(this.m_btnLowSpeed_Click);
            // 
            // LaserParaAdjust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "LaserParaAdjust";
            this.Size = new System.Drawing.Size(478, 263);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton m_radioTeachSetting;
        private System.Windows.Forms.RadioButton m_radioNowSetting;
        private System.Windows.Forms.TextBox m_txbPolarize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_txbLaserPower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox m_txbDec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox m_Speed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox m_txbAcc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_txbZOffset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button m_btnHighSpeed;
        private System.Windows.Forms.CheckBox m_chbFilterOn;
        private System.Windows.Forms.Button m_btnLowSpeed;
        private System.Windows.Forms.Button m_btnMiddleSpeed;
        private System.Windows.Forms.RadioButton m_radioCounterclockwise;
        private System.Windows.Forms.RadioButton m_radioClockwise;
    }
}
